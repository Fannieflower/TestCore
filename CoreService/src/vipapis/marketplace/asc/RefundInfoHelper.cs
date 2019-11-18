using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.marketplace.asc{
	
	
	
	public class RefundInfoHelper : TBeanSerializer<RefundInfo>
	{
		
		public static RefundInfoHelper OBJ = new RefundInfoHelper();
		
		public static RefundInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(RefundInfo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("return_goods_money".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetReturn_goods_money(value);
					}
					
					
					
					
					
					if ("return_goods_fav".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetReturn_goods_fav(value);
					}
					
					
					
					
					
					if ("send_carriage".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetSend_carriage(value);
					}
					
					
					
					
					
					if ("back_carriage".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetBack_carriage(value);
					}
					
					
					
					
					
					if ("return_vipmoney".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetReturn_vipmoney(value);
					}
					
					
					
					
					
					if ("return_redpacket".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetReturn_redpacket(value);
					}
					
					
					
					
					
					if ("return_amount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetReturn_amount(value);
					}
					
					
					
					
					
					if ("return_type".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReturn_type(value);
					}
					
					
					
					
					
					if ("refund_total".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetRefund_total(value);
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
		
		
		public void Write(RefundInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetReturn_goods_money() != null) {
				
				oprot.WriteFieldBegin("return_goods_money");
				oprot.WriteDouble((double)structs.GetReturn_goods_money());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReturn_goods_fav() != null) {
				
				oprot.WriteFieldBegin("return_goods_fav");
				oprot.WriteDouble((double)structs.GetReturn_goods_fav());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSend_carriage() != null) {
				
				oprot.WriteFieldBegin("send_carriage");
				oprot.WriteDouble((double)structs.GetSend_carriage());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBack_carriage() != null) {
				
				oprot.WriteFieldBegin("back_carriage");
				oprot.WriteDouble((double)structs.GetBack_carriage());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReturn_vipmoney() != null) {
				
				oprot.WriteFieldBegin("return_vipmoney");
				oprot.WriteDouble((double)structs.GetReturn_vipmoney());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReturn_redpacket() != null) {
				
				oprot.WriteFieldBegin("return_redpacket");
				oprot.WriteDouble((double)structs.GetReturn_redpacket());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReturn_amount() != null) {
				
				oprot.WriteFieldBegin("return_amount");
				oprot.WriteDouble((double)structs.GetReturn_amount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReturn_type() != null) {
				
				oprot.WriteFieldBegin("return_type");
				oprot.WriteString(structs.GetReturn_type());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRefund_total() != null) {
				
				oprot.WriteFieldBegin("refund_total");
				oprot.WriteDouble((double)structs.GetRefund_total());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(RefundInfo bean){
			
			
		}
		
	}
	
}