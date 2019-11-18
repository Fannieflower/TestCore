using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.bulkbuying.api{
	
	
	
	public class PurchaseOrderHelper : TBeanSerializer<PurchaseOrder>
	{
		
		public static PurchaseOrderHelper OBJ = new PurchaseOrderHelper();
		
		public static PurchaseOrderHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PurchaseOrder structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("purchase_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchase_no(value);
					}
					
					
					
					
					
					if ("delivery_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDelivery_no(value);
					}
					
					
					
					
					
					if ("receive_warehouse_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReceive_warehouse_name(value);
					}
					
					
					
					
					
					if ("receive_warehouse_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReceive_warehouse_code(value);
					}
					
					
					
					
					
					if ("delivery_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetDelivery_time(value);
					}
					
					
					
					
					
					if ("purchase_type".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPurchase_type(value);
					}
					
					
					
					
					
					if ("vendor_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVendor_code(value);
					}
					
					
					
					
					
					if ("vendor_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVendor_name(value);
					}
					
					
					
					
					
					if ("company_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCompany_code(value);
					}
					
					
					
					
					
					if ("return_address".Equals(schemeField.Trim())){
						
						needSkip = false;
						vipapis.xstore.cc.bulkbuying.api.Address value;
						
						value = new vipapis.xstore.cc.bulkbuying.api.Address();
						vipapis.xstore.cc.bulkbuying.api.AddressHelper.getInstance().Read(value, iprot);
						
						structs.SetReturn_address(value);
					}
					
					
					
					
					
					if ("buyer_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyer_name(value);
					}
					
					
					
					
					
					if ("is_whale_warehouse".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetIs_whale_warehouse(value);
					}
					
					
					
					
					
					if ("receiving_type".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetReceiving_type(value);
					}
					
					
					
					
					
					if ("goods_type".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetGoods_type(value);
					}
					
					
					
					
					
					if ("distributable_goods_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetDistributable_goods_time(value);
					}
					
					
					
					
					
					if ("cooperationMode".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetCooperationMode(value);
					}
					
					
					
					
					
					if ("rfid_template_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRfid_template_code(value);
					}
					
					
					
					
					
					if ("is_crossdock".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetIs_crossdock(value);
					}
					
					
					
					
					
					if ("owner_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOwner_code(value);
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
		
		
		public void Write(PurchaseOrder structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPurchase_no() != null) {
				
				oprot.WriteFieldBegin("purchase_no");
				oprot.WriteString(structs.GetPurchase_no());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDelivery_no() != null) {
				
				oprot.WriteFieldBegin("delivery_no");
				oprot.WriteString(structs.GetDelivery_no());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReceive_warehouse_name() != null) {
				
				oprot.WriteFieldBegin("receive_warehouse_name");
				oprot.WriteString(structs.GetReceive_warehouse_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReceive_warehouse_code() != null) {
				
				oprot.WriteFieldBegin("receive_warehouse_code");
				oprot.WriteString(structs.GetReceive_warehouse_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDelivery_time() != null) {
				
				oprot.WriteFieldBegin("delivery_time");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetDelivery_time())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchase_type() != null) {
				
				oprot.WriteFieldBegin("purchase_type");
				oprot.WriteI32((int)structs.GetPurchase_type()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendor_code() != null) {
				
				oprot.WriteFieldBegin("vendor_code");
				oprot.WriteString(structs.GetVendor_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendor_name() != null) {
				
				oprot.WriteFieldBegin("vendor_name");
				oprot.WriteString(structs.GetVendor_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCompany_code() != null) {
				
				oprot.WriteFieldBegin("company_code");
				oprot.WriteString(structs.GetCompany_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReturn_address() != null) {
				
				oprot.WriteFieldBegin("return_address");
				
				vipapis.xstore.cc.bulkbuying.api.AddressHelper.getInstance().Write(structs.GetReturn_address(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyer_name() != null) {
				
				oprot.WriteFieldBegin("buyer_name");
				oprot.WriteString(structs.GetBuyer_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIs_whale_warehouse() != null) {
				
				oprot.WriteFieldBegin("is_whale_warehouse");
				oprot.WriteByte((byte)structs.GetIs_whale_warehouse()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReceiving_type() != null) {
				
				oprot.WriteFieldBegin("receiving_type");
				oprot.WriteByte((byte)structs.GetReceiving_type()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGoods_type() != null) {
				
				oprot.WriteFieldBegin("goods_type");
				oprot.WriteI32((int)structs.GetGoods_type()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("goods_type can not be null!");
			}
			
			
			if(structs.GetDistributable_goods_time() != null) {
				
				oprot.WriteFieldBegin("distributable_goods_time");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetDistributable_goods_time())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCooperationMode() != null) {
				
				oprot.WriteFieldBegin("cooperationMode");
				oprot.WriteByte((byte)structs.GetCooperationMode()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRfid_template_code() != null) {
				
				oprot.WriteFieldBegin("rfid_template_code");
				oprot.WriteString(structs.GetRfid_template_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIs_crossdock() != null) {
				
				oprot.WriteFieldBegin("is_crossdock");
				oprot.WriteString(structs.GetIs_crossdock());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOwner_code() != null) {
				
				oprot.WriteFieldBegin("owner_code");
				oprot.WriteString(structs.GetOwner_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PurchaseOrder bean){
			
			
		}
		
	}
	
}