using System.Collections.Generic;
using Newtonsoft.Json;


namespace K8SApi.Models{

    public class Elements{

        [JsonProperty("elements")]
        public IList<Element> ElementList { get; set; }
    }
    public class Element{

        [JsonProperty("name")]
        public string Name {get; set;}
        
        [JsonProperty("appearance")]
        public string Appearance {get; set;}
        
        [JsonProperty("atomic")]
        public double AtomicMass {get; set;}

//        public int Number {get;  set;}
//        public int Period {get;  set;}

    /* 
        "boil": 20.271, 
        "category": "diatomic nonmetal", 
        "color": null, 
        "density": 0.08988, 
        "discovered_by": "Henry Cavendish", 
        "melt": 13.99, 
        "molar_heat": 28.836, 
        "named_by": "Antoine Lavoisier", 
    */

    }
}