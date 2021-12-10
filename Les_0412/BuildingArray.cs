namespace Les_0412
{
    class BuildingArray
    {
        private Building[] array;

        public BuildingArray()
        {
            array = new Building[10];
        }

        public Building this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }
    }
}