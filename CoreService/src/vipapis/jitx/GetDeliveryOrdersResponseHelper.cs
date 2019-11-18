using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.jitx{
	
	
	
	public class GetDeliveryOrdersResponseHelper : TBeanSerializer<GetDeliveryOrdersResponse>
	{
		
		public static GetDeliveryOrdersResponseHelper OBJ = new GetDeliveryOrdersResponseHelper();
		
		public static GetDeliveryOrdersResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GetDeliveryOrdersResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("total".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetTotal(value);
					}
					
					
					
					
					
					if ("delivery_orders".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.jitx.DeliveryOrder> value;
						
						value = new List<vipapis.jitx.DeliveryOrder>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.jitx.DeliveryOrder elem1;
								
								elem1 = new vipapis.jitx.DeliveryOrder();
								vipapis.jitx.DeliveryOrderHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetDelivery_orders(value);
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
		
		
		public void Write(GetDeliveryOrdersResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTotal() != null) {
				
				oprot.WriteFieldBegin("total");
				oprot.WriteI32((int)structs.GetTotal()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDelivery_orders() != null) {
				
				oprot.WriteFieldBegin("delivery_orders");
				
				oprot.WriteListBegin();
				foreach(vipapis.jitx.DeliveryOrder _item0 in structs.GetDelivery_orders()){
					
					
					vipapis.jitx.DeliveryOrderHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GetDeliveryOrdersResponse bean){
			
			
		}
		
	}
	
}