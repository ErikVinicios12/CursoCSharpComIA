namespace ModificadoresDeAcesso
{
    internal class MinhaClasse // internal - accessible only within the same assembly
    {
        int meuCampo;  // private by default - accessible only within the class
        public int MeuCampo { get; set; };; // public property - accessible from anywhere

        void MeuMetodo() // private by default - accessible only within the class
        {
         
        }
        protected void MeuMetodoProtegido() // protected - accessible within the class and derived classes
        {

        }
    }
}
