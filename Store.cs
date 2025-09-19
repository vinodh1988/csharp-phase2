namespace phase2 {
    public class Store<T>{
        private T data;

        public T Data { 
            get { return data; } 
            set { data = value; } 
        }   

        public void DisplayType(){
            Console.WriteLine($"Type of T is: {typeof(T)}");
        }

        public void DisplayData(){
            Console.WriteLine($"Data: {data}");
        }   
    }
}