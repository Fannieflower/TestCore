using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.order{
	
	
	
	public class OxoReturnOrderResponseHelper : TBeanSerializer<OxoReturnOrderResponse>
	{
		
		public static OxoReturnOrderResponseHelper OBJ = new OxoReturnOrderResponseHelper();
		
		public static OxoReturnOrderResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(OxoReturnOrderResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("has_next".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetHas_next(value);
					}
					
					
					
					
					
					if ("oxo_return_orders".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.order.OxoReturnOrder> value;
						
						value = new List<vipapis.order.OxoReturnOrder>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.order.OxoReturnOrder elem1;
								
								elem1 = new vipapis.order.OxoReturnOrder();
								vipapis.order.OxoReturnOrderHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetOxo_return_orders(value);
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
		
		
		public void Write(OxoReturnOrderResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetHas_next() != null) {
				
				oprot.WriteFieldBegin("has_next");
				oprot.WriteBool((bool)structs.GetHas_next());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("has_next can not be null!");
			}
			
			
			if(structs.GetOxo_return_orders() != null) {
				
				oprot.WriteFieldBegin("oxo_return_orders");
				
				oprot.WriteListBegin();
				foreach(vipapis.order.OxoReturnOrder _item0 in structs.GetOxo_return_orders()){
					
					
					vipapis.order.OxoReturnOrderHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("oxo_return_orders can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(OxoReturnOrderResponse bean){
			
			
		}
		
	}
	
}