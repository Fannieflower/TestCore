using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.ubc.facade.bankcard{
	
	
	
	public class BankDataRequestHelper : TBeanSerializer<BankDataRequest>
	{
		
		public static BankDataRequestHelper OBJ = new BankDataRequestHelper();
		
		public static BankDataRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(BankDataRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("bankName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBankName(value);
					}
					
					
					
					
					
					if ("dataStr".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDataStr(value);
					}
					
					
					
					
					
					if ("dataNum".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetDataNum(value);
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
		
		
		public void Write(BankDataRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetBankName() != null) {
				
				oprot.WriteFieldBegin("bankName");
				oprot.WriteString(structs.GetBankName());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("bankName can not be null!");
			}
			
			
			if(structs.GetDataStr() != null) {
				
				oprot.WriteFieldBegin("dataStr");
				oprot.WriteString(structs.GetDataStr());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("dataStr can not be null!");
			}
			
			
			if(structs.GetDataNum() != null) {
				
				oprot.WriteFieldBegin("dataNum");
				oprot.WriteI32((int)structs.GetDataNum()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("dataNum can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(BankDataRequest bean){
			
			
		}
		
	}
	
}