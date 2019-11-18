using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.ubc.facade.bankcard{
	
	
	
	public class BankFileResponseHelper : TBeanSerializer<BankFileResponse>
	{
		
		public static BankFileResponseHelper OBJ = new BankFileResponseHelper();
		
		public static BankFileResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(BankFileResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("result".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetResult(value);
					}
					
					
					
					
					
					if ("bankName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBankName(value);
					}
					
					
					
					
					if(needSkip){
						
						ProtocolUtil.skip(iprot);
					}
					
					iprot.ReadFieldEnd();
				}
				
				iprot.ReadStructEnd();
				Validate(structs);
			}
			else{
				
				throw new OspException();
			}
			
			
		}
		
		
		public void Write(BankFileResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetResult() != null) {
				
				oprot.WriteFieldBegin("result");
				oprot.WriteI32((int)structs.GetResult()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBankName() != null) {
				
				oprot.WriteFieldBegin("bankName");
				oprot.WriteString(structs.GetBankName());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(BankFileResponse bean){
			
			
		}
		
	}
	
}