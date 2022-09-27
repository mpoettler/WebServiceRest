namespace DnssWebApi
{
    internal class PropertiesObject
    {
        private int x;
        private int y;
        private int z;
        private int index;
        private string name;

        public PropertiesObject(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public PropertiesObject(int index, string name,int x, int y, int z )
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.index = index;
            this.name = name;
        }
    }
}