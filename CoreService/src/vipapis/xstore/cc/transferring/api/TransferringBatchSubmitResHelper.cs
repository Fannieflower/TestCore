using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.transferring.api{
	
	
	
	public class TransferringBatchSubmitResHelper : TBeanSerializer<TransferringBatchSubmitRes>
	{
		
		public static TransferringBatchSubmitResHelper OBJ = new TransferringBatchSubmitResHelper();
		
		public static TransferringBatchSubmitResHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(TransferringBatchSubmitRes structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("transferring_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransferring_no(value);
					}
					
					
					
					
					
					if ("items".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.xstore.cc.transferring.api.TransferringOrderImportItem> value;
						
						value = new List<vipapis.xstore.cc.transferring.api.TransferringOrderImportItem>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.xstore.cc.transferring.api.TransferringOrderImportItem elem0;
								
								elem0 = new vipapis.xstore.cc.transferring.api.TransferringOrderImportItem();
								vipapis.xstore.cc.transferring.api.TransferringOrderImportItemHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetItems(value);
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
		
		
		public void Write(TransferringBatchSubmitRes structs, Protocol oprot){
			
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
			
			
			if(structs.GetTransferring_no() != null) {
				
				oprot.WriteFieldBegin("transferring_no");
				oprot.WriteString(structs.GetTransferring_no());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetItems() != null) {
				
				oprot.WriteFieldBegin("items");
				
				oprot.WriteListBegin();
				foreach(vipapis.xstore.cc.transferring.api.TransferringOrderImportItem _item0 in structs.GetItems()){
					
					
					vipapis.xstore.cc.transferring.api.TransferringOrderImportItemHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(TransferringBatchSubmitRes bean){
			
			
		}
		
	}
	
}