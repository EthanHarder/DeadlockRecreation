#ifndef ADDITIONAL_LIGHT_INCLUDED
#define ADDITIONAL_LIGHT_INCLUDED
#ifndef CUSTOM_LIGHTING_INCLUDED
#define CUSTOM_LIGHTING_INCLUDED



void MainLight_float(float3 WorldPos, 
    out float3 Direction, out float3 Color, out float Attenuation, out float ShadowAttenuation)
{
  
   #ifdef SHADERGRAPH_PREVIEW
        Direction = normalize(float3(1.0f, 1.0f, 0.0f));
        Color = 1.0f;
        Attenuation = 1.0f; 
        ShadowAttenuation = 1.0f;
   #else
   #if SHADOWS_SCREEN
        float4 clipPOS = TransformWorldToHClip(WorldPos);
        float4 shadowCoord = ComputeScreenPos(clipPos);
    #else
        float4 shadowCoord = TransformWorldToShadowCoord(WorldPos);
    #endif
    
        Light mainLight = GetMainLight(shadowCoord);
    Direction = mainLight.direction;
    Color = mainLight.color;
    Attenuation = mainLight.distanceAttenuation;
    ShadowSamplingData shadowSamplingData = GetMainLightShadowSamplingData();
    float shadowStrength = GetMainLightShadowStrength();
    ShadowAttenuation = SampleShadowmap(shadowCoord, TEXTURE2D_ARGS(_MainLightShadowmapTexture, sampler_MainLightShadowmapTexture), shadowSamplingData, shadowStrength, false);
    
   #endif
}

void AdditionalLight_float(float3 WorldPos, int lightID,
    out float3 Direction, out float3 Color, out float Attenuation)
{

        Direction = normalize(float3(1.0f, 1.0f, 0.0f));
    Color = float3(0.0f, 0.0f, 0.0f);
        Attenuation = 1.0f;
#ifndef SHADERGRAPH_PREVIEW
    int lightCount = GetAdditionalLightsCount();
    
    if (lightID < lightCount)
    {
        Light light = GetAdditionalLight(lightID, WorldPos);
        Direction = light.direction;
        Color = light.color;
        Attenuation = light.distanceAttenuation;
        
    
    
    }
    else
    {
        

    }

    
#endif
}

void AllAdditionalLights_float(float3 WorldPos, float3 WorldNormal, float4 CutoffThresholds, out float3 LightColor)
{
    LightColor = 0.0f;
 
#ifndef SHADERGRAPH_PREVIEW
    int lightCount = GetAdditionalLightsCount();

    for (int i = 0; i < lightCount; ++i)
    {
        Light light = GetAdditionalLight(i, WorldPos);

        float3 color = saturate(dot(light.direction, WorldNormal));
        
        float localAttenuation = saturate(light.distanceAttenuation * 3);
        
        /*
        float AttenLow = CutoffThresholds.b;
        float AttenHigh = CutoffThresholds.a;
        if (localAttenuation <= AttenLow)
            localAttenuation = 0.0f;
        else if (localAttenuation <= AttenHigh)
           localAttenuation = 0.4f;
        else
            localAttenuation = 2.0f;
        */
            
        //if (localAttenuation)  <= CutoffThresholds.x
       
        
        color += smoothstep(CutoffThresholds.x, CutoffThresholds.x, color);
        
        color += smoothstep(CutoffThresholds.y, CutoffThresholds.y, color);
        
        //color = smoothstep()
        
       
        
        
        
        
        
        color *= localAttenuation;
        
        color *= (light.color % 1);
        
       
     
        
        


        LightColor += color;
        //LightColor.r += 1.0f;
    }
#endif
}


#endif
#endif // ADDITIOANL_LIGHT_INCLUDED
