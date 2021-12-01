namespace Ucu.Poo.Defense
{
    public class MaterialType
    {
        public string Name { get; set; }

        public Material Material;
        public bool isDangerous;
    

        public MaterialType(string name, bool isDangerous)
        {
            this.Name = name;
            this.isDangerous=isDangerous;
        }
    }    
}