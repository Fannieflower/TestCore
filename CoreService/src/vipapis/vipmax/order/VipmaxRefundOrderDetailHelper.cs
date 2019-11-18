using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.vipmax.order{
	
	
	
	public class VipmaxRefundOrderDetailHelper : TBeanSerializer<VipmaxRefundOrderDetail>
	{
		
		public static VipmaxRefundOrderDetailHelper OBJ = new VipmaxRefundOrderDetailHelper();
		
		public static VipmaxRefundOrderDetailHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(VipmaxRefundOrderDetail structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("sku_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSku_id(value);
					}
					
					
					
					
					
					if ("refund_quantity".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetRefund_quantity(value);
					}
					
					
					
					
					
					if ("refund_price".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetRefund_price(value);
					}
					
					
					
					
					
					if ("title".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTitle(value);
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
		
		
		public void Write(VipmaxRefundOrderDetail structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetSku_id() != null) {
				
				oprot.WriteFieldBegin("sku_id");
				oprot.WriteString(structs.GetSku_id());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("sku_id can not be null!");
			}
			
			
			if(structs.GetRefund_quantity() != null) {
				
				oprot.WriteFieldBegin("refund_quantity");
				oprot.WriteI32((int)structs.GetRefund_quantity()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("refund_quantity can not be null!");
			}
			
			
			if(structs.GetRefund_price() != null) {
				
				oprot.WriteFieldBegin("refund_price");
				oprot.WriteDouble((double)structs.GetRefund_price());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("refund_price can not be null!");
			}
			
			
			if(structs.GetTitle() != null) {
				
				oprot.WriteFieldBegin("title");
				oprot.WriteString(structs.GetTitle());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(VipmaxRefundOrderDetail bean){
			
			
		}
		
	}
	
}