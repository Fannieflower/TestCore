using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.transferring.api{
	
	
	
	public class TransferringBatchImportDetailResHelper : TBeanSerializer<TransferringBatchImportDetailRes>
	{
		
		public static TransferringBatchImportDetailResHelper OBJ = new TransferringBatchImportDetailResHelper();
		
		public static TransferringBatchImportDetailResHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(TransferringBatchImportDetailRes structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCode(value);
					}
					
					
					
					
					
					if ("message".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMessage(value);
					}
					
					
					
					
					
					if ("results".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.xstore.cc.transferring.api.TransferringBatchImportItemResult> value;
						
						value = new List<vipapis.xstore.cc.transferring.api.TransferringBatchImportItemResult>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.xstore.cc.transferring.api.TransferringBatchImportItemResult elem0;
								
								elem0 = new vipapis.xstore.cc.transferring.api.TransferringBatchImportItemResult();
								vipapis.xstore.cc.transferring.api.TransferringBatchImportItemResultHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetResults(value);
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
		
		
		public void Write(TransferringBatchImportDetailRes structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCode() != null) {
				
				oprot.WriteFieldBegin("code");
				oprot.WriteString(structs.GetCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMessage() != null) {
				
				oprot.WriteFieldBegin("message");
				oprot.WriteString(structs.GetMessage());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetResults() != null) {
				
				oprot.WriteFieldBegin("results");
				
				oprot.WriteListBegin();
				foreach(vipapis.xstore.cc.transferring.api.TransferringBatchImportItemResult _item0 in structs.GetResults()){
					
					
					vipapis.xstore.cc.transferring.api.TransferringBatchImportItemResultHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(TransferringBatchImportDetailRes bean){
			
			
		}
		
	}
	
}