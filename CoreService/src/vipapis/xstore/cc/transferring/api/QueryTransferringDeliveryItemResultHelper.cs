using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.transferring.api{
	
	
	
	public class QueryTransferringDeliveryItemResultHelper : TBeanSerializer<QueryTransferringDeliveryItemResult>
	{
		
		public static QueryTransferringDeliveryItemResultHelper OBJ = new QueryTransferringDeliveryItemResultHelper();
		
		public static QueryTransferringDeliveryItemResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(QueryTransferringDeliveryItemResult structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("transferring_delivery_items".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.xstore.cc.transferring.api.TransferringDeliveryItem> value;
						
						value = new List<vipapis.xstore.cc.transferring.api.TransferringDeliveryItem>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.xstore.cc.transferring.api.TransferringDeliveryItem elem0;
								
								elem0 = new vipapis.xstore.cc.transferring.api.TransferringDeliveryItem();
								vipapis.xstore.cc.transferring.api.TransferringDeliveryItemHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetTransferring_delivery_items(value);
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
		
		
		public void Write(QueryTransferringDeliveryItemResult structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTransferring_delivery_items() != null) {
				
				oprot.WriteFieldBegin("transferring_delivery_items");
				
				oprot.WriteListBegin();
				foreach(vipapis.xstore.cc.transferring.api.TransferringDeliveryItem _item0 in structs.GetTransferring_delivery_items()){
					
					
					vipapis.xstore.cc.transferring.api.TransferringDeliveryItemHelper.getInstance().Write(_item0, oprot);
					
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
		
		
		public void Validate(QueryTransferringDeliveryItemResult bean){
			
			
		}
		
	}
	
}