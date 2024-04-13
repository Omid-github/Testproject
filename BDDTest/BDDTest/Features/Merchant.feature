Feature: Merchant
          Merchant Scenarios for Sadad portal 

Background:
    Given The user logins successfully 


@CreateMerchant
Scenario: Create Merchant

	Given The user is Navigated to the CreateMerchant form 
    When  The user fills out merchant information as following :

	    | TermType        | SwitchType | DivisionCode   | PersonType | Firstname  | FirstnameEn | NationalCode   | ParentShaparakMccCode | ShaparakMcc | JobTitle  | EmailAddress            | WebSite                | MerchantMobileNo | OtherOrgAgency  | BirthDate  | LicenseDate | LastName| LastNameEN | FatherName | IdentityNo | IdNoSerial   | LetterID  | IdNoSeriesNumber  | MaritalStatus   | SexCode        | PassExpiryDate      | PassportNo |
	    | درگاه اینترنتی | سوییچ دو  | تست سداد      | حقیقی      | رامین     | Ramin        | 0783431805     | تعاونی مسکن          | تعاونی مسکن | حسابدار  | accounttest@sadadpsp.ir | https://www.test22.com | 9125525252       | تست عاملیت     | 1368/05/18 | 1368/05/10  | فرجی    | Faraji     | سعید       | 0082282838 | 614351	  |ب         | 35               |  مجرد			    |  مرد           | 1401/02/01          |  25251236  |
	    | پایانه فروشگاهی| سوییچ دو  | تست سداد      | حقیقی	     | رامین     | Ramin        | 0783431805     | تعاونی مسکن          | تعاونی مسکن | حسابدار  | accounttest@sadadpsp.ir | https://www.test22.com | 9125525252       | تست عاملیت     | 1368/05/18 | 1368/05/10  | فرجی    | Faraji     | سعید       | 0082282838 | 614351      |ب         | 35				 |  مجرد		    |  مرد           | 1401/02/01          |  25251236  |
	    | پایانه فروشگاهی| سوییچ دو  | تست سداد      | حقوقی	     | رامین     | Ramin        | 0783431805     | تعاونی مسکن          | تعاونی مسکن | حسابدار  | accounttest@sadadpsp.ir | https://www.test22.com | 9125525252       | تست عاملیت     | 1368/05/18 | 1368/05/10  | فرجی    | Faraji     | سعید       | 0082282838 | 614351      |ب         | 35				 |   مجرد			|  مرد           | 1401/02/01          |  25251236  |
		 
	And The user fills Merchant address information as following:
	    | TxtAddressTypeCode | TxtCityPK  | TelephoneNo     | CitySection | AddressFull  | AddressFullEN | Postalcode |
	    | آدرس محل کار      | تهران	  | 21-22855252     | 3           | خ شریعتی    |  Shariati St  | 1541697123 |
	
    And The user fill signatory information as following:
	    | RowSig | SigNationality | SigFirstname | SigLastname  | SigNationalcode  | SigPassNo  | SigBirthdate |
	    | 2      | ایران         | امید         | حاجی         |  0440034922      |  13524163  |   1362/10/09 |       
	And   The user submits
    Then  The Merchant should be created successfully 
	



@EditMerchant
Scenario: Edit Merchant

    Given   The user navigated to the Merchant Page
	And     The user searches for a merchant based on CardAcqId <CardAcqId>
	And     The user edits the specfied merchant
    When    The user edit merchant information as following :
	  
	  | DivisionCode   | PersonType | Firstname | FirstnameEn  | NationalCode  | ParentShaparakMccCode  | ShaparakMcc  | JobTitle    | EmailAddress              | WebSite                | MerchantMobileNo | OtherOrgAgency  | BirthDate  | LicenseDate | LastName| LastNameEN | FatherName  | IdentityNo | IdNoSerial   | LetterID      | IdNoSeriesNumber      | MaritalStatus  | SexCode		       | PassExpiryDate   | PassportNo   |
	  | تست سداد      | حقیقی      | رامین     | Ramin        | 0783431805    |  خ                     | س		      	| حسابدار   | accounttest@sadadpsp.ir   | https://www.test22.com | 9125525252       | تست عاملیت     | 1368/05/18 | 1368/05/10  | فرجی    | Faraji     | سعید       | 0082282838  | 614351	    |الف         | 35                       |  مجرد	         |  مرد			    	 | 1401/02/01     |  25251236    |
	  | تست سداد      | حقیقی	     | رامین     | Ramin       | 0783431805    | تعاونی مسکن           | تعاونی مسکن  | حسابدار    | accounttest@sadadpsp.ir   | https://www.test22.com | 9125525252       | تست عاملیت     | 1368/05/18 | 1368/05/10  | فرجی    | Faraji     | سعید      | 0082282838  | 614351        |الف           | 35				       |  مجرد			 |  مرد				   | 1401/02/01       |  25251236    |
	  | تست سداد      | حقوقی	     | رامین     | Ramin       | 0783431805    | تعاونی مسکن          | تعاونی مسکن  | حسابدار   | accounttest@sadadpsp.ir   | https://www.test22.com | 9125525252       | تست عاملیت     | 1368/05/18 | 1368/05/10  | فرجی    | Faraji     | سعید       | 0082282838  | 614351        |الف           | 35				       |   مجرد			 |  مرد				   | 1401/02/01       |  25251236    |
		  
	And The user edit merchant address information as following:
	  
	    | TxtAddressTypeCode | TxtCityPK  | TelephoneNo     | CitySection | AddressFull  | AddressFullEN | Postalcode |
	    | آدرس محل کار      | تهران	  | 21-22855252     | 3           | خ شریعتی    |  Shariati St  | 1541697123 |
	
	
    And The user edit signatory information as following:
	    | RowSig | SigNationality | SigFirstname | SigLastname  | SigNationalcode | SigPassNo  | SigBirthdate |
	    | 33    | ایران           | امید        | حاجی         |  0440034922     |  13524163 |   1362/10/09  |       
    Then  The Merchant should be modified successfully 

	Examples:
	| CardAcqId			|
	|  000000000000929  | 




	@CloneMerchant
Scenario: Clone Merchant

   
   Given   The user navigated to the Merchant Page
	And     The user searches for a merchant based on CardAcqId <CardAcqId>
   And     The user clones the specfied merchant <CardAcqId>

	When  The user edit merchant information as following :

	    | TermType        | SwitchType | DivisionCode   | PersonType | Firstname | FirstnameEn  | NationalCode  | ParentShaparakMccCode | ShaparakMcc  | JobTitle   | EmailAddress            | WebSite                | MerchantMobileNo | OtherOrgAgency  | BirthDate  | LicenseDate | LastName| LastNameEN | FatherName | IdentityNo  | IdNoSerial  | LetterID  | IdNoSeriesNumber  | MaritalStatus    | SexCode   | PassExpiryDate  | PassportNo |
	    | درگاه اینترنتی | سوییچ دو  | تست سداد      | حقیقی      | رامین     | Ramin        | 0783431805    |خ                      |س            | حسابدار  | accounttest@sadadpsp.ir | https://www.test22.com | 9125525252       | تست عاملیت     | 1368/05/18 | 1368/05/10  | فرجی    | Faraji     | سعید       | 0082282838 | 614351	     |الف        | 35                |  مجرد			|  مرد      | 1401/02/01       |  25251236  |
	    | پایانه فروشگاهی| سوییچ دو  | تست سداد      | حقیقی	     | رامین     | Ramin        | 0783431805    | تعاونی مسکن          | تعاونی مسکن | حسابدار  | accounttest@sadadpsp.ir | https://www.test22.com | 9125525252       | تست عاملیت     | 1368/05/18 | 1368/05/10  | فرجی    | Faraji     | سعید       | 0082282838 | 614351      |الف        | 35				 |  مجرد			|  مرد      | 1401/02/01       |  25251236  |
	    | پایانه فروشگاهی| سوییچ دو  | تست سداد      | حقوقی	     | رامین     | Ramin        | 0783431805    | تعاونی مسکن          | تعاونی مسکن | حسابدار  | accounttest@sadadpsp.ir | https://www.test22.com | 9125525252       | تست عاملیت     | 1368/05/18 | 1368/05/10  | فرجی    | Faraji     | سعید       | 0082282838 | 614351      |الف        | 35				 |   مجرد			|  مرد      | 1401/02/01       |  25251236  |
		
	And The user customize merchant address information as following:
	  
	    | TxtAddressTypeCode | TxtCityPK  | TelephoneNo     | CitySection | AddressFull  | AddressFullEN | Postalcode |
	    | آدرس محل کار      | تهران	  | 21-22855252     | 3           | خ شریعتی    |  Shariati St  | 1541697123 |
	    
	
	And   The user submits
    Then  The merchant should be cloned successfully 
	   

	   Examples:
	              | CardAcqId			|
				  |  000000130880895    | 
  


 @CreateRelatedMerchant
Scenario: Create Related Merchant

     
	Given The user is Navigated to the CreateMerchant form 
	When  The User fills out merchant information as following :

	    | TermType        | SwitchType | DivisionCode   | PersonType | Firstname  | FirstnameEn  | NationalCode  | ParentShaparakMccCode | ShaparakMcc | JobTitle  | EmailAddress            | WebSite                | MerchantMobileNo | OtherOrgAgency  | BirthDate  | LicenseDate | LastName| LastNameEN | FatherName | IdentityNo | IdNoSerial  | LetterID  | IdNoSeriesNumber  | MaritalStatus    | SexCode   | PassExpiryDate | PassportNo |
	    | درگاه اینترنتی | سوییچ دو  | تست سداد      | حقیقی      | رامین     | Ramin        | 0783431805    | تع                     | ت           | حسابدار  | accounttest@sadadpsp.ir | https://www.test22.com | 9125525252       | تست عاملیت     | 1368/05/18 | 1368/05/10  | فرجی    | Faraji     | سعید       | 0082282838 | 614351	     |الف        | 35                |  مجرد			|  مرد      | 1401/02/01     |  25251236  |
	    | پایانه فروشگاهی| سوییچ دو  | تست سداد      | حقیقی	     | رامین     | Ramin        | 0783431805    | تعاونی مسکن           | تعاونی مسکن | حسابدار  | accounttest@sadadpsp.ir | https://www.test22.com | 9125525252       | تست عاملیت     | 1368/05/18 | 1368/05/10  | فرجی    | Faraji     | سعید       | 0082282838 | 614351      |الف        | 35				 |  مجرد			|  مرد      | 1401/02/01     |  25251236  |
	    | پایانه فروشگاهی| سوییچ دو  | تست سداد      | حقوقی	     | رامین     | Ramin        | 0783431805    | تعاونی مسکن           | تعاونی مسکن | حسابدار  | accounttest@sadadpsp.ir | https://www.test22.com | 9125525252       | تست عاملیت     | 1368/05/18 | 1368/05/10  | فرجی    | Faraji     | سعید       | 0082282838 | 614351      |الف        | 35				 |   مجرد			|  مرد      | 1401/02/01     |  25251236  |
		 
	And The user fills Merchant address information as following:
	    | TxtAddressTypeCode | TxtCityPK  | TelephoneNo     | CitySection | AddressFull  | AddressFullEN | Postalcode |
	    | آدرس محل کار      | تهران	  | 21-22855252     | 3           | خ شریعتی    |  Shariati St  | 1541697123 |
	
    And The user fill signatory information as following:
	    | RowSig | SigNationality  | SigFirstname  | SigLastname  | SigNationalcode | SigPassNo   | SigBirthdate |
	    | 2      | ایران          | امید          | حاجی         |  0440034922     |  13524163   |   1362/10/09 |  

   And The user fill SubMerchant information as following:
	    | SubMerchantPk     | CommercialCode | RelationTypeLookupId |
	    | 000000130880829   |   1020304050   |	نماینده رسمی       |   
		
	And   The user submits
    Then  The related merchant should be created successfully 
	   




  @EditMerchantAddress
Scenario: Edit Merchant Address

   
   Given    The user searches for a merchant based on CardAcqId <CardAcqId> 
   When   The user updates merchant address information as following:
	    | TxtAddressTypeCode | TxtCityPK  | TelephoneNo     | CitySection | AddressFull  | AddressFullEN | Postalcode |
	    | آدرس محل کار      | تهران	  | 21-22855252     | 3           | خ شریعتی    |  Shariati St  | 10101942864 |
   Then  The merchant Address should be updated successfully 
	

	   Examples:
	             | CardAcqId			|
	             |  000000000000071     | 



	 @ChangeMerchantPersonTypeToLegal
Scenario: Change Merchant PersonType to Legal

   Given    The user searches for a merchant based on CardAcqId <CardAcqId> 
   When   The user fills out legal merchant information as following:
	  |  FirstName  | FirstNameEn     | NationalCode   | TxtCountryCode	  | LicenseNo     | LicenseDate |
	  | رامین       | Ramin           | 0783431805     | ایران			  | خ شریعتی     |  1362/10/09 |       
	And   The user submits
    Then  The merchant should be changed to Legal successfully 

	   Examples:
	| CardAcqId			|
	|  000000000000071  | 



	 @ChangeMerchantPersonTypeToNatural
Scenario: Change Merchant PersonType to natural

   Given    The user searches for a Legal merchant based on CardAcqId <CardAcqId> and PersonType <PersonType>
   When   The user fills out natural merchant information as following:

	  | Firstname  | FirstnameEn  | NationalCode  | LastName | LastNameEN | FatherName  | TxtCountryCode | IdentityNo | IdNoSerial | LetterID | IdNoSeriesNumber | MaritalStatus | SexCode  | PassExpiryDate    | PassportNo    |
	  | رامین      | Ramin        | 0783431805   | حاجی     | Haji       | Hossein     | ایران          | 0082282838 | 614351     | الف      | 35              | مجرد          | مرد      | 1401/02/01        | 25251236      |   
	  
	And   The user submits 
    Then  The merchant should be changed to natural successfully 

	   Examples:
 	           | CardAcqId       | PersonType |
 	           | 000000000002745 |  حقوقی     |



        