using System.Collections.Generic;
using System.ComponentModel;


namespace ViewObjects.Images
{
    public class ImageViewObject : BaseViewObject
    {
        
        public string Description { get; set; }

        public List<Component> Components
    {
        get;
        set;
    }

    }
}
