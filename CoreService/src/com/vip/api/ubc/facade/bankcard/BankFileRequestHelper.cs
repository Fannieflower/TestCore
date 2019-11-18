using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.ubc.facade.bankcard{
	
	
	
	public class BankFileRequestHelper : TBeanSerializer<BankFileRequest>
	{
		
		public static BankFileRequestHelper OBJ = new BankFileRequestHelper();
		
		public static BankFileRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(BankFileRequest structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("fileStreamStr".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetFileStreamStr(value);
					}
					
					
					
					
					
					if ("fileDataNum".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetFileDataNum(value);
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
		
		
		public void Write(BankFileRequest structs, Protocol oprot){
			
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
			
			
			if(structs.GetFileStreamStr() != null) {
				
				oprot.WriteFieldBegin("fileStreamStr");
				oprot.WriteString(structs.GetFileStreamStr());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("fileStreamStr can not be null!");
			}
			
			
			if(structs.GetFileDataNum() != null) {
				
				oprot.WriteFieldBegin("fileDataNum");
				oprot.WriteI32((int)structs.GetFileDataNum()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(BankFileRequest bean){
			
			
		}
		
	}
	
}