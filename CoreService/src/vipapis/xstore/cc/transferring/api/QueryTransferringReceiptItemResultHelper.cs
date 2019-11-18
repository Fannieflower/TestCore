using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.transferring.api{
	
	
	
	public class QueryTransferringReceiptItemResultHelper : TBeanSerializer<QueryTransferringReceiptItemResult>
	{
		
		public static QueryTransferringReceiptItemResultHelper OBJ = new QueryTransferringReceiptItemResultHelper();
		
		public static QueryTransferringReceiptItemResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(QueryTransferringReceiptItemResult structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("transferring_received_items".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.xstore.cc.transferring.api.TransferringReceivedItem> value;
						
						value = new List<vipapis.xstore.cc.transferring.api.TransferringReceivedItem>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.xstore.cc.transferring.api.TransferringReceivedItem elem0;
								
								elem0 = new vipapis.xstore.cc.transferring.api.TransferringReceivedItem();
								vipapis.xstore.cc.transferring.api.TransferringReceivedItemHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetTransferring_received_items(value);
					}
					
					
					
					
					
					if ("total".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetTotal(value);
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
		
		
		public void Write(QueryTransferringReceiptItemResult structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTransferring_received_items() != null) {
				
				oprot.WriteFieldBegin("transferring_received_items");
				
				oprot.WriteListBegin();
				foreach(vipapis.xstore.cc.transferring.api.TransferringReceivedItem _item0 in structs.GetTransferring_received_items()){
					
					
					vipapis.xstore.cc.transferring.api.TransferringReceivedItemHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTotal() != null) {
				
				oprot.WriteFieldBegin("total");
				oprot.WriteI32((int)structs.GetTotal()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(QueryTransferringReceiptItemResult bean){
			
			
		}
		
	}
	
}