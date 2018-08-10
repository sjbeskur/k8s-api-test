

using System.Collections.Generic;
using System.IO;
using K8SApi.Models;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;

namespace K8SApi{

    /* Fake service for testing K8S pod communications */
    public interface IElementService{
            IEnumerable<Element> ElementList{ get; }
        
    }

    public class ElementService : IElementService{

        public ElementService(IHostingEnvironment hev){
            string webRoot = hev.ContentRootPath;
            string path = Path.Combine(webRoot, "elements.json");
            using (StreamReader r = new StreamReader(path)){
                string json = r.ReadToEnd();
                var result = JsonConvert.DeserializeObject<Elements>(json);
                ElementList = result.ElementList;                                
            }    
        }            

        public IEnumerable<Element> ElementList{ get; private set;}
    }

}