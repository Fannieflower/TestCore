using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.bulkbuying.api{
	
	
	
	public class PoRefundRealItemHelper : TBeanSerializer<PoRefundRealItem>
	{
		
		public static PoRefundRealItemHelper OBJ = new PoRefundRealItemHelper();
		
		public static PoRefundRealItemHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PoRefundRealItem structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("txid".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTxid(value);
					}
					
					
					
					
					
					if ("purchase_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchase_no(value);
					}
					
					
					
					
					
					if ("barcode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBarcode(value);
					}
					
					
					
					
					
					if ("sub_disability_level".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSub_disability_level(value);
					}
					
					
					
					
					
					if ("selling_status".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte value;
						value = iprot.ReadByte(); 
						
						structs.SetSelling_status(value);
					}
					
					
					
					
					
					if ("box_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBox_no(value);
					}
					
					
					
					
					
					if ("refund_quantity".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetRefund_quantity(value);
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
		
		
		public void Write(PoRefundRealItem structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTxid() != null) {
				
				oprot.WriteFieldBegin("txid");
				oprot.WriteString(structs.GetTxid());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("txid can not be null!");
			}
			
			
			if(structs.GetPurchase_no() != null) {
				
				oprot.WriteFieldBegin("purchase_no");
				oprot.WriteString(structs.GetPurchase_no());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("purchase_no can not be null!");
			}
			
			
			if(structs.GetBarcode() != null) {
				
				oprot.WriteFieldBegin("barcode");
				oprot.WriteString(structs.GetBarcode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("barcode can not be null!");
			}
			
			
			if(structs.GetSub_disability_level() != null) {
				
				oprot.WriteFieldBegin("sub_disability_level");
				oprot.WriteString(structs.GetSub_disability_level());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("sub_disability_level can not be null!");
			}
			
			
			if(structs.GetSelling_status() != null) {
				
				oprot.WriteFieldBegin("selling_status");
				oprot.WriteByte((byte)structs.GetSelling_status()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("selling_status can not be null!");
			}
			
			
			if(structs.GetBox_no() != null) {
				
				oprot.WriteFieldBegin("box_no");
				oprot.WriteString(structs.GetBox_no());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRefund_quantity() != null) {
				
				oprot.WriteFieldBegin("refund_quantity");
				oprot.WriteI32((int)structs.GetRefund_quantity()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("refund_quantity can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PoRefundRealItem bean){
			
			
		}
		
	}
	
}