Feature: Takhsis
          Takhsis Scenarios for Sadad portal 


@TakhsisPos
Scenario:Takhsis Pos

     Given  The user logins successfully 
	 And    The user searches for the Merchant request based on <MerchantNo> and <ContractNo>
     When   The user performs Takhsis operation
	 And    The user fills terminal request informations as following:

		  | TermModel      | InstallLocNameEN | PostalCode | ParentShaparakMccCode	 | ShaparakMcc     | ExistanceStatusCode  | TerminalIBAN                  | MultiPlexingValuBehaviourId |
		  | BlueBird_CT360 | TestStore        | 1541697152 | دامپزشکی               | خدمات دامپزشکی | عادي 111             | IR820550021380004819974001    | مقدار جاری                 |
		
		
     And   The user sumbits for TAKHSIS
	 Then Terminal request should be assigned to a serialNo successfully

    Examples: 

	   | MerchantNo     | ContractNo		|
	   | 000000130476612| MC0000000048637	|
	     
	 

	@TakhsisIPG
Scenario:TakhsisIPG

     Given  The user logins successfully 
	 And    The user searches for the Merchant request based on <MerchantNo> and <ContractNo>
     When   The user performs Takhsis operation
	 And    The user fills IPG Assign informations as following:

		| TermType        | InstallLocNameEN | PostalCode  | InstallLoc_MobileNo | IBAN						  |
		| پایانه اینترنتی | TestStore       | 1541697152  |	9121167545	     | IR030170000000307413960008 |           
	
	 And The user fills IPG Specific information as following:

	    | StoreUrl					  | Organization			  | StoreIp		| StorePort  | StoreEmail		    | EnamadStartDate | EnamadEndDate | RemainReversal | ReverseTimeOut |
	    | https://www.testStore.com   | اپراتورهای تلفن همراه   | 192.168.5.5 | 2020       | https://testBDD.com  |  1398/01/01     |   1402/01/01  | 30 دقیقه       |    25 دقیقه   |      
		  
     And   The user sumbits for TAKHSIS
     Then Terminal request should be assigned to a serialNo successfully


    Examples: 

		  | MerchantNo      | ContractNo      |
		  | M00000000000295 | MC0000000000301 |
								
	
	
	@RejectRequest
Scenario:RejectRequest

     Given  The user logins successfully 
	 And    The user searches for the Merchant request based on <MerchantNo> and <ContractNo>
     When   The user rejects the TAKHSIS request
	 Then   The reject operation should be done successfully

    Examples: 

		  | MerchantNo      | ContractNo      |
		  | M00000000000295 | MC0000000000301 |
								