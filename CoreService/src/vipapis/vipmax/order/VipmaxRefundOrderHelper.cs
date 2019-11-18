using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.vipmax.order{
	
	
	
	public class VipmaxRefundOrderHelper : TBeanSerializer<VipmaxRefundOrder>
	{
		
		public static VipmaxRefundOrderHelper OBJ = new VipmaxRefundOrderHelper();
		
		public static VipmaxRefundOrderHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(VipmaxRefundOrder structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("refund_order_sn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRefund_order_sn(value);
					}
					
					
					
					
					
					if ("refund_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetRefund_time(value);
					}
					
					
					
					
					
					if ("refund_order_detail".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.vipmax.order.VipmaxRefundOrderDetail> value;
						
						value = new List<vipapis.vipmax.order.VipmaxRefundOrderDetail>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.vipmax.order.VipmaxRefundOrderDetail elem0;
								
								elem0 = new vipapis.vipmax.order.VipmaxRefundOrderDetail();
								vipapis.vipmax.order.VipmaxRefundOrderDetailHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetRefund_order_detail(value);
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
		
		
		public void Write(VipmaxRefundOrder structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetRefund_order_sn() != null) {
				
				oprot.WriteFieldBegin("refund_order_sn");
				oprot.WriteString(structs.GetRefund_order_sn());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("refund_order_sn can not be null!");
			}
			
			
			if(structs.GetRefund_time() != null) {
				
				oprot.WriteFieldBegin("refund_time");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetRefund_time())); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("refund_time can not be null!");
			}
			
			
			if(structs.GetRefund_order_detail() != null) {
				
				oprot.WriteFieldBegin("refund_order_detail");
				
				oprot.WriteListBegin();
				foreach(vipapis.vipmax.order.VipmaxRefundOrderDetail _item0 in structs.GetRefund_order_detail()){
					
					
					vipapis.vipmax.order.VipmaxRefundOrderDetailHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("refund_order_detail can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(VipmaxRefundOrder bean){
			
			
		}
		
	}
	
}