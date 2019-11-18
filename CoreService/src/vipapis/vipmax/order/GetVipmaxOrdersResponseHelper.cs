using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.vipmax.order{
	
	
	
	public class GetVipmaxOrdersResponseHelper : TBeanSerializer<GetVipmaxOrdersResponse>
	{
		
		public static GetVipmaxOrdersResponseHelper OBJ = new GetVipmaxOrdersResponseHelper();
		
		public static GetVipmaxOrdersResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GetVipmaxOrdersResponse structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("vipmax_orders".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.vipmax.order.VipmaxOrder> value;
						
						value = new List<vipapis.vipmax.order.VipmaxOrder>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.vipmax.order.VipmaxOrder elem1;
								
								elem1 = new vipapis.vipmax.order.VipmaxOrder();
								vipapis.vipmax.order.VipmaxOrderHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetVipmax_orders(value);
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
		
		
		public void Write(GetVipmaxOrdersResponse structs, Protocol oprot){
			
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
			
			
			if(structs.GetVipmax_orders() != null) {
				
				oprot.WriteFieldBegin("vipmax_orders");
				
				oprot.WriteListBegin();
				foreach(vipapis.vipmax.order.VipmaxOrder _item0 in structs.GetVipmax_orders()){
					
					
					vipapis.vipmax.order.VipmaxOrderHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GetVipmaxOrdersResponse bean){
			
			
		}
		
	}
	
}