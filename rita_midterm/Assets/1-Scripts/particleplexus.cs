using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(ParticleSystem))]

public class particleplexus : MonoBehaviour
{
    public float maxDistance = 1.0f;
    new ParticleSystem particleSystem;
    ParticleSystem.Particle[] particles;
    ParticleSystem.MainModule particleSystemMainModule;

    //The Line Renderer component takes an array of two or more points in 3D space, and draws a straight line between each one.
    public LineRenderer lineRendererTemplate;
    List<LineRenderer> lineRenderers = new List<LineRenderer>(); //keep track of all the line renderers so we can reuse them


    Transform _transform;
  
        

    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
        particleSystemMainModule = particleSystem.main;
        _transform = transform;
    }

    void LateUpdate()
    {
        int maxParticles = particleSystemMainModule.maxParticles;
        if (particles == null || particles.Length < maxParticles)
        {
            particles = new ParticleSystem.Particle[maxParticles];
        }

        particleSystem.GetParticles(particles);
        int particleCount = particleSystem.particleCount;

        float maxDistanceSqr = maxDistance * maxDistance;

        int lrIndex = 0;
        int lineRendererCount = lineRenderers.Count;

        //make a switch system to make sure the simulation space is correct
        switch (particleSystemMainModule.simulationSpace)
        {
            case ParticleSystemSimulationSpace.Local:
                {
                    break;
                }

            case ParticleSystemSimulationSpace.Custom:
                {
                    break;
                }
            case ParticleSystemSimulationSpace.World:
                {
                    break;
                }


                /*
            default:
                {

                    throw new System.NotSupportedException
                   {
                       string.Format("Unsuppported Simulation Space '{0}'.", System.Enum.GetName(typeof(ParticleSystemSimulationSpace),particleSystemMainModule.simulationSpace))

                   }
                }

                */

        }


        //keep track of which line renderer we are working with
   
        //keep track of the count of list of line renderers

        //compare every single particle position and every other particle position
        //if at max distance we will create a connection between the two
        for (int i = 0; i < particleCount; i++)

        {
            Vector3 p1_position = particles[i].position;
            for (int j = i+1; j <particleCount;j++)
            {
                Vector3 p2_position = particles[j].position; // the second particle position
                float distanceSqr = Vector3.SqrMagnitude(p1_position - p2_position);
                if (distanceSqr<= maxDistanceSqr)
                {

                    LineRenderer lr;
                     
                    if (lrIndex == lineRendererCount)
                    {
                        
                        lr = Instantiate(lineRendererTemplate, transform, false);
                        lineRenderers.Add(lr);
                        lineRendererCount++;
                    }

                    lr = lineRenderers[lrIndex];
                    lr.enabled = true;
                    lr.SetPosition(0, p1_position); // set position of line renderer to the first particle position
                    lr.SetPosition(1, p2_position);// set position of line renderer to the second particle position
                    lrIndex++;
                }
            }





        }

        //make sure any unused line renderers are disabled
        for (int i = lrIndex; i < lineRenderers.Count; i++)
        {
            lineRenderers[i].enabled = false;
        }
    }
}
