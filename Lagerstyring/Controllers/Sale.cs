namespace Lagerstyring.Controllers{
    public class Sale{
        private int merchType;
        private int antal;
        private double salePrice;
        public Sale(int merchType, int antal, double salePrice){
            this.merchType = merchType;
            this.antal = antal;
            this.salePrice = salePrice;

            updateStock();
            saveSale();
        }

        public void updateStock(){
            
        }

        public void saveSale(){
            
        }
    }
}