using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.jitx{
	
	
	
	public class BelleDeliveryOrderResponseHelper : TBeanSerializer<BelleDeliveryOrderResponse>
	{
		
		public static BelleDeliveryOrderResponseHelper OBJ = new BelleDeliveryOrderResponseHelper();
		
		public static BelleDeliveryOrderResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(BelleDeliveryOrderResponse structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("orders".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.jitx.BelleDeliveryOrder> value;
						
						value = new List<vipapis.jitx.BelleDeliveryOrder>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.jitx.BelleDeliveryOrder elem1;
								
								elem1 = new vipapis.jitx.BelleDeliveryOrder();
								vipapis.jitx.BelleDeliveryOrderHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetOrders(value);
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
		
		
		public void Write(BelleDeliveryOrderResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTotal() != null) {
				
				oprot.WriteFieldBegin("total");
				oprot.WriteI32((int)structs.GetTotal()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrders() != null) {
				
				oprot.WriteFieldBegin("orders");
				
				oprot.WriteListBegin();
				foreach(vipapis.jitx.BelleDeliveryOrder _item0 in structs.GetOrders()){
					
					
					vipapis.jitx.BelleDeliveryOrderHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(BelleDeliveryOrderResponse bean){
			
			
		}
		
	}
	
}