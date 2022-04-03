package com.qa.rest.test;
import static io.restassured.RestAssured.get;
import static io.restassured.RestAssured.*;
import static io.restassured.RestAssured.given;
import static org.hamcrest.Matchers.equalTo;
import static org.hamcrest.Matchers.*;

import io.restassured.RestAssured;
import io.restassured.response.Response;

import static org.testng.Assert.assertEquals;

import org.testng.Assert;
import org.testng.annotations.Test;

import groovy.util.logging.Log;

public class GetCall {
   
	@Test
	public  void test_numberOfCircuits2017() {
		
	// given().
	// when().
	// then().
	// assert().
		//given().
		
		//when().
		
		 Response response = get("https://reqres.in/api/users?page=2");
		 System.out.println(response.asString());
		 System.out.println(response.getBody().asString());
		 System.out.println(response.getStatusCode());
		 System.out.println(response.getStatusLine());//then().
		 System.out.println(response.getHeader("content-type"));
		 System.out.println(response.getTime());
           int statuscode = response.getStatusCode();
           Assert.assertEquals( statuscode, 200);
		// assertThat().
		 
		 //and().
		 //body("MRData.CircuitTable.Circuits.CircuitId", hasSize(20)).
		 //and().
		 //header("content-Lenght" , equalTo("4551"));
      
		
	}

	 void bdd() {
		// TODO Auto-generated method stub
		given()
		       .get("https://reqres.in/api/users?page=2")
		.then()
		       .statusCode(200) 
		       .body("data.id[0]", equalTo(7) ).
		        body("data.first_name", hasItems("Michael","Lindsay"));
	} 
	 
	
	

	
	
	
	
}
