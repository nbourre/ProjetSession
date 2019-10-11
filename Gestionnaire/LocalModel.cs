namespace Gestionnaire
{
    class LocalModel
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Numero + " : " + Description;
        }
    }
}
