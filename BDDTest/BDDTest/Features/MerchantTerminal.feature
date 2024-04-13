Feature: MerchantTerminal
         MerhantTerminal Scenarios for Sadad portal 


@AddIBAN

Scenario: AddIBAN
 Given  The user logins successfully 
 And    Navigates to the MerchantTerminal form
 And    The user searches for a contract based on MerchantNo <CardAcqId> and TerminalID <TerminalID>
 When   The user adds account information as following :
	   
	 | TermPaymentMode | MultiplexingValueBehaviorId | MerchantTerminalIBAN_StatusCode | Percentage | Amount | Description			       | MerchantIBAN						  |
	 | واریز انتخابی   | مقدار جاری                | فعال                            | 100        | 0      | افزایش حساب پذیرنده       |  IR470170000000340147240104			  |

 And   The user performs shaparak confirmation for the Merchant <Merchant>
 Then  IBAN number shoud be linked to the terminal successfully
  	
  Examples: 
		  | CardAcqId       | TerminalID | Merchant			 |
		  | 000000150001857 | 33013799   | 000000150001857   |



@RemoveAccount

Scenario: RemoveAccount
 Given  The user logins successfully 
 And    Navigates to the MerchantTerminal form
 And    The user searches for a contract based on MerchantNo <CardAcqId> and TerminalID <TerminalID>
 When   The user removes the Account number with following information:
       |          TermPaymentMode	            | Description             |
       |	 واریز عادی _واریز در یک حساب		|  افزایش حساب پذیرنده   |
 And    The user performs shaparak confirmation for the Merchat <CardAcqId>
 Then   IBAN number shoud be unlinked from the terminal successfully
  	
   Examples:
		  | CardAcqId       | TerminalID   |
		  | 000000140337771 | 24097333     |



