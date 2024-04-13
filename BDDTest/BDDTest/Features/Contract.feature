Feature: Contract
         Contract Scenarios for Sadad portal 


@CreateContract

Scenario: CreateContract
 Given  The user logins successfully 
 And    Navigates to the CreateMerchantContract Form
 When   The user fills out Contract information as following :
	  
	    | CardAcqid		  | Agency     | StoreNameFA    | Branch	  | RequestedTermsCount  | Termtype				| RowNo	| IBAN							| AccountNo			| PartialBank   | PartialBankZone			 | IBANStatusCode			  |               
	    | 000000140337788 | اصفهان    | تست سداد       | سیدخندان   | 1			         | پایانه فروشگاهی     | 1     |	IR810170000000227545995008	|	0227545995008   |   ملی			|	اداره امور تست سداد	 |     درخواست حساب فعال     |       	

 And   The user submits 
 Then  The contract should be created successfully 
  	
 



 @EditContract
Scenario: EditContract

   Given  The user logins successfully 
   And    Navigates to the MerchantContract Form
   And    The user searches for a contract based on MerchantNo <MerchantNo> and ContractNo <ContractNo>
   When   The user Edits Contract information as following:

	    | CardAcqid       | Agency | StoreNameFA  | StoreNameEN  | Branch     | RequestedTermsCount | Termtype          | RowNo | IBAN                       | AccountNo		 |AccountTitle		| PartialBank	| PartialBankZone			| IBANStatusCode     |
	    | 000000140337788 | اصفهان | تست سداد    | شریعتی      | سیدخندان  | 1                   | پایانه فروشگاهی  | 3     | IR810170000000227545995008 | 0227545995008     |       حساب فرعی	|  ملی			|	اداره امور تست سداد   |  درخواست حساب فعال|       	

   And   The user submits 
   Then  The contract should be modified successfully 

    Examples: 
		  | MerchantNo      | ContractNo      |
		  | 000000130880868 | MC0000001839571 |


   @CloneContract
Scenario: CloneContract
   Given  The user logins successfully 
   And    Navigates to the MerchantTerminal Form
   And    The user searches for a contract based on MerchantNo <MerchantNo> and ContractNo <ContractNo>
   When   The user clones a contract for the specified Merchant <CardAcqId>
   And    The user submits 
   Then   The contract should be cloned successfully 


     Examples: 
		  | MerchantNo      | ContractNo      | CardAcqId       |
		  | 000000130880868 | MC0000001839571 | 000000140199645 |


