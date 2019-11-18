using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.cup.api.order{
	
	
	
	public class GetOrderStatusResultHelper : TBeanSerializer<GetOrderStatusResult>
	{
		
		public static GetOrderStatusResultHelper OBJ = new GetOrderStatusResultHelper();
		
		public static GetOrderStatusResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GetOrderStatusResult structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("result".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.vop.cup.api.order.Result value;
						
						value = new com.vip.vop.cup.api.order.Result();
						com.vip.vop.cup.api.order.ResultHelper.getInstance().Read(value, iprot);
						
						structs.SetResult(value);
					}
					
					
					
					
					
					if ("order_status_info_list".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.cup.api.order.OrderStatusInfo> value;
						
						value = new List<com.vip.vop.cup.api.order.OrderStatusInfo>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.cup.api.order.OrderStatusInfo elem1;
								
								elem1 = new com.vip.vop.cup.api.order.OrderStatusInfo();
								com.vip.vop.cup.api.order.OrderStatusInfoHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetOrder_status_info_list(value);
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
		
		
		public void Write(GetOrderStatusResult structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetResult() != null) {
				
				oprot.WriteFieldBegin("result");
				
				com.vip.vop.cup.api.order.ResultHelper.getInstance().Write(structs.GetResult(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrder_status_info_list() != null) {
				
				oprot.WriteFieldBegin("order_status_info_list");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.cup.api.order.OrderStatusInfo _item0 in structs.GetOrder_status_info_list()){
					
					
					com.vip.vop.cup.api.order.OrderStatusInfoHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GetOrderStatusResult bean){
			
			
		}
		
	}
	
}