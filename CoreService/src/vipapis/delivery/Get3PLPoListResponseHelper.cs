using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.delivery{
	
	
	
	public class Get3PLPoListResponseHelper : TBeanSerializer<Get3PLPoListResponse>
	{
		
		public static Get3PLPoListResponseHelper OBJ = new Get3PLPoListResponseHelper();
		
		public static Get3PLPoListResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(Get3PLPoListResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("po_orders".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.delivery.SimplePurchaseOrder> value;
						
						value = new List<vipapis.delivery.SimplePurchaseOrder>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.delivery.SimplePurchaseOrder elem0;
								
								elem0 = new vipapis.delivery.SimplePurchaseOrder();
								vipapis.delivery.SimplePurchaseOrderHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetPo_orders(value);
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
		
		
		public void Write(Get3PLPoListResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPo_orders() != null) {
				
				oprot.WriteFieldBegin("po_orders");
				
				oprot.WriteListBegin();
				foreach(vipapis.delivery.SimplePurchaseOrder _item0 in structs.GetPo_orders()){
					
					
					vipapis.delivery.SimplePurchaseOrderHelper.getInstance().Write(_item0, oprot);
					
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
		
		
		public void Validate(Get3PLPoListResponse bean){
			
			
		}
		
	}
	
}