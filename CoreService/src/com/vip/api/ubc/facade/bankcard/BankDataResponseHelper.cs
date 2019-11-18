using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.ubc.facade.bankcard{
	
	
	
	public class BankDataResponseHelper : TBeanSerializer<BankDataResponse>
	{
		
		public static BankDataResponseHelper OBJ = new BankDataResponseHelper();
		
		public static BankDataResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(BankDataResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("dataNum".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetDataNum(value);
					}
					
					
					
					
					
					if ("successDataNum".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetSuccessDataNum(value);
					}
					
					
					
					
					
					if ("failedDataNum".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetFailedDataNum(value);
					}
					
					
					
					
					
					if ("bankName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBankName(value);
					}
					
					
					
					
					
					if ("result".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.api.ubc.facade.bankcard.OperationResult> value;
						
						value = new List<com.vip.api.ubc.facade.bankcard.OperationResult>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.api.ubc.facade.bankcard.OperationResult elem0;
								
								elem0 = new com.vip.api.ubc.facade.bankcard.OperationResult();
								com.vip.api.ubc.facade.bankcard.OperationResultHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetResult(value);
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
		
		
		public void Write(BankDataResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetDataNum() != null) {
				
				oprot.WriteFieldBegin("dataNum");
				oprot.WriteI32((int)structs.GetDataNum()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSuccessDataNum() != null) {
				
				oprot.WriteFieldBegin("successDataNum");
				oprot.WriteI32((int)structs.GetSuccessDataNum()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFailedDataNum() != null) {
				
				oprot.WriteFieldBegin("failedDataNum");
				oprot.WriteI32((int)structs.GetFailedDataNum()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBankName() != null) {
				
				oprot.WriteFieldBegin("bankName");
				oprot.WriteString(structs.GetBankName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetResult() != null) {
				
				oprot.WriteFieldBegin("result");
				
				oprot.WriteListBegin();
				foreach(com.vip.api.ubc.facade.bankcard.OperationResult _item0 in structs.GetResult()){
					
					
					com.vip.api.ubc.facade.bankcard.OperationResultHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(BankDataResponse bean){
			
			
		}
		
	}
	
}