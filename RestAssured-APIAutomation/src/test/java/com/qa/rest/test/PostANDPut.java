package com.qa.rest.test;
import static io.restassured.RestAssured.given;
import static org.hamcrest.Matchers.equalTo;
import static org.hamcrest.Matchers.hasItems;

import java.util.HashMap;
import java.util.Map;

import org.json.simple.JSONObject;
import org.testng.annotations.Test;

import io.restassured.http.ContentType;



public class PostANDPut {
   
	@Test
	
		
	// given().
	// when().
	// then().
	// assert().
		//given().
		
		//when().
		
		
		 
		// assertThat().
		 
		 //and().
		 //body("MRData.CircuitTable.Circuits.CircuitId", hasSize(20)).
		 //and().
		 //header("content-Lenght" , equalTo("4551"));
      
		
	

	 public void POSTCall() {
		
	    ///create body of post request 
		JSONObject request =  new JSONObject();
		request.put("name", "Raghaev");
		request.put("job", "teacher");

		System.out.println(request);
		System.out.println(request.toJSONString());
		//now send request
		given().
		
		       header("Content-Type", "application/json").
		       contentType(ContentType.JSON).
		       accept(ContentType.JSON).
		       body(request.toJSONString()).       
		  when().
		  
	           post("https://reqres.in/api/users").
	       	
	      then().
	
	        statusCode(201);
	     //  .body("data.id[0]", equalTo(7) ).
	      //  body("data.last_name", hasItems("Fields","Edwards"));
		
	} 
	@Test
	 public void PUTCall() {
			
		    ///create body of PUT request for update action
			JSONObject request =  new JSONObject();
			request.put("name", "Raghaev");
			request.put("job", "teacher");

			System.out.println(request);
			System.out.println(request.toJSONString());
			//now send request
			given().
			
			       header("Content-Type", "application/json").
			       contentType(ContentType.JSON).
			       accept(ContentType.JSON).
			       body(request.toJSONString()).       
			  when().
			  
		           put("https://reqres.in/api/users/2").
		       	
		      then().
		
		        statusCode(200).log().all();
		     //  .body("data.id[0]", equalTo(7) ).
		      //  body("data.last_name", hasItems("Fields","Edwards"));
			
		} 
	 
	 
	
	

	
	
	
	
}
