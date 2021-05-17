namespace csharp
{

    /*
    An object
    */
    public class Model
    {
        private string name;
        private int age;


        /* Constructor */
        public Model(){

        }


        /* Getters and setters  */
        public void setName(string name){
            this.name = name;
        }
        public string getName(){
            return this.name;
        }


        public void setAge(int age){
            this.age = age;
        }
        public int getAge(){
            return this.age;
        }
        
    }
}