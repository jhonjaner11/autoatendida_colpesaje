using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleLPR3;

namespace Placas
{
    class Obtener_Placa
    {
        public string get_placa(string image)
        {
            string placa = "";

            // Create an instance of the SimpleLPR engine.
            EngineSetupParms setupP;
            setupP.cudaDeviceId = -1; // Select CPU
            setupP.enableImageProcessingWithGPU = false;
            setupP.enableClassificationWithGPU = false;
            setupP.maxConcurrentImageProcessingOps = 0;  // Use the default value.  

            ISimpleLPR lpr = SimpleLPR.Setup(setupP);
            // Set the product key
            //lpr.set_productKey("");
            // Enable Germany, Spain andthe United Kingdom
            lpr.set_countryWeight("Colombia", 1.0f);
            //lpr.set_countryWeight(“Spain”, 1.0f);
            //lpr.set_countryWeight(“UK - GreatBritain”, 1.0f);
            // Apply changes
            lpr.realizeCountryWeights();

            // Create Processor
            IProcessor proc = lpr.createProcessor();
            // Process source file
            List<Candidate> cds = proc.analyze(image);
            //Console.WriteLine("{0} license plate candidates found:", cds.Count);
            // Iterate over all candidates
            foreach (Candidate cd in cds)
            {
                //Console.WriteLine("***********");
                //Console.WriteLine("Light background: {0}, left: {1}, top: {2}, width: {3}, height: {4}",cd.brightBackground, cd.bbox.Left, cd.bbox.Top, cd.bbox.Width, cd.bbox.Height);
                //Console.WriteLine("Matches:");
                // Iterate over all country matches
                foreach (CountryMatch match in cd.matches)
                {

                    if (match.country == "Colombia")
                    {
                        //txt_placa.Text = match.text;
                        placa = match.text;

                    }
                    //Console.WriteLine("-----------");
                    //Console.WriteLine("Text: {0}, country: {1}, ISO: {2}, confidence: {3}",match.text, match.country, match.countryISO, match.confidence);
                    //Console.WriteLine("Elements:");
                    foreach (Element e in match.elements)
                    {
                        //Console.WriteLine("   Glyph: {0}, confidence: {1}," +"left: {2}, top: {3}, width: {4}, height: {5}",e.glyph, e.confidence, e.bbox.Left, e.bbox.Top, e.bbox.Width, e.bbox.Height);
                    }
                }
            }


            placa = placa.Replace("-", "");
            return placa;

        }
    }
}
