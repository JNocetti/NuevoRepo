namespace Ucu.Poo.Defense
{
    public class Material
    {
        public string Name { get; set; }

        public MaterialType Type;
     

        public Material(string name, MaterialType type)
        {
            this.Name = name;
            this.Type = type;
        }

        public bool IsDangerous()
        {
            if (this.Type.isDangerous==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}