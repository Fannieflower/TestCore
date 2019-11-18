using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.transferring.api{
	
	
	
	public class TransferringOrderItemApiResultHelper : TBeanSerializer<TransferringOrderItemApiResult>
	{
		
		public static TransferringOrderItemApiResultHelper OBJ = new TransferringOrderItemApiResultHelper();
		
		public static TransferringOrderItemApiResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(TransferringOrderItemApiResult structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("transferring_order_items".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.xstore.cc.transferring.api.TransferringOrderItemApiModel> value;
						
						value = new List<vipapis.xstore.cc.transferring.api.TransferringOrderItemApiModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.xstore.cc.transferring.api.TransferringOrderItemApiModel elem0;
								
								elem0 = new vipapis.xstore.cc.transferring.api.TransferringOrderItemApiModel();
								vipapis.xstore.cc.transferring.api.TransferringOrderItemApiModelHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetTransferring_order_items(value);
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
		
		
		public void Write(TransferringOrderItemApiResult structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTransferring_order_items() != null) {
				
				oprot.WriteFieldBegin("transferring_order_items");
				
				oprot.WriteListBegin();
				foreach(vipapis.xstore.cc.transferring.api.TransferringOrderItemApiModel _item0 in structs.GetTransferring_order_items()){
					
					
					vipapis.xstore.cc.transferring.api.TransferringOrderItemApiModelHelper.getInstance().Write(_item0, oprot);
					
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
		
		
		public void Validate(TransferringOrderItemApiResult bean){
			
			
		}
		
	}
	
}