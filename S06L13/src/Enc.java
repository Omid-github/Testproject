class demo{
	private String name;
	private int id;
	
	
	public void SetData(String name1,int id1) {
		this.id =  id1;
		this.name = name1;
		//System.out.println("Name : "+ this.name);
		//System.out.println("id : "+ this.id);

		
	}
	
	
	public int getId() {
		return id;
	}
	public String getname() {
		return name;
	}
	
	
	
	
	
	
	
	
	
	
	
	
}
public class Enc {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		demo user = new demo();
		user.SetData("omid", 18);
		System.out.println("ID: "+user.getId());
		System.out.println("Name: "+user.getname());

	}

}
