using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.cup.api.order{
	
	
	
	public class OrderOpResultHelper : TBeanSerializer<OrderOpResult>
	{
		
		public static OrderOpResultHelper OBJ = new OrderOpResultHelper();
		
		public static OrderOpResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(OrderOpResult structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("succ_order_sn_list".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								string elem1;
								elem1 = iprot.ReadString();
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetSucc_order_sn_list(value);
					}
					
					
					
					
					
					if ("failed_order_sn_list".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.cup.api.order.FailMsg> value;
						
						value = new List<com.vip.vop.cup.api.order.FailMsg>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.cup.api.order.FailMsg elem2;
								
								elem2 = new com.vip.vop.cup.api.order.FailMsg();
								com.vip.vop.cup.api.order.FailMsgHelper.getInstance().Read(elem2, iprot);
								
								value.Add(elem2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetFailed_order_sn_list(value);
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
		
		
		public void Write(OrderOpResult structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetResult() != null) {
				
				oprot.WriteFieldBegin("result");
				
				com.vip.vop.cup.api.order.ResultHelper.getInstance().Write(structs.GetResult(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSucc_order_sn_list() != null) {
				
				oprot.WriteFieldBegin("succ_order_sn_list");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetSucc_order_sn_list()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFailed_order_sn_list() != null) {
				
				oprot.WriteFieldBegin("failed_order_sn_list");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.cup.api.order.FailMsg _item0 in structs.GetFailed_order_sn_list()){
					
					
					com.vip.vop.cup.api.order.FailMsgHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(OrderOpResult bean){
			
			
		}
		
	}
	
}