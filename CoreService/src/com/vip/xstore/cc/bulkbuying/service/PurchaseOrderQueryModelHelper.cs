using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.cc.bulkbuying.service{
	
	
	
	public class PurchaseOrderQueryModelHelper : TBeanSerializer<PurchaseOrderQueryModel>
	{
		
		public static PurchaseOrderQueryModelHelper OBJ = new PurchaseOrderQueryModelHelper();
		
		public static PurchaseOrderQueryModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PurchaseOrderQueryModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("queryNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								string elem0;
								elem0 = iprot.ReadString();
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetQueryNo(value);
					}
					
					
					
					
					
					if ("queryType".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetQueryType(value);
					}
					
					
					
					
					
					if ("companyCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCompanyCode(value);
					}
					
					
					
					
					
					if ("visibility".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetVisibility(value);
					}
					
					
					
					
					
					if ("approvalStatus".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetApprovalStatus(value);
					}
					
					
					
					
					
					if ("deliveryStatus".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetDeliveryStatus(value);
					}
					
					
					
					
					
					if ("stockProps".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetStockProps(value);
					}
					
					
					
					
					
					if ("deliveryWarehouse".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDeliveryWarehouse(value);
					}
					
					
					
					
					
					if ("createTimeStart".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetCreateTimeStart(value);
					}
					
					
					
					
					
					if ("pageSize".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPageSize(value);
					}
					
					
					
					
					
					if ("page".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPage(value);
					}
					
					
					
					
					
					if ("buyerId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyerId(value);
					}
					
					
					
					
					
					if ("createTimeEnd".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetCreateTimeEnd(value);
					}
					
					
					
					
					
					if ("vendorCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVendorCode(value);
					}
					
					
					
					
					
					if ("vendorName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVendorName(value);
					}
					
					
					
					
					
					if ("purchaseType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchaseType(value);
					}
					
					
					
					
					
					if ("approvalRole".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetApprovalRole(value);
					}
					
					
					
					
					
					if ("barcodeType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetBarcodeType(value);
					}
					
					
					
					
					
					if ("barcodes".Equals(schemeField.Trim())){
						
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
						
						structs.SetBarcodes(value);
					}
					
					
					
					
					
					if ("goodsType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetGoodsType(value);
					}
					
					
					
					
					
					if ("source".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSource(value);
					}
					
					
					
					
					
					if ("cooperationMode".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetCooperationMode(value);
					}
					
					
					
					
					
					if ("goodsChannel".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetGoodsChannel(value);
					}
					
					
					
					
					
					if ("receivingType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetReceivingType(value);
					}
					
					
					
					
					
					if ("receiveWarehouseCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReceiveWarehouseCode(value);
					}
					
					
					
					
					
					if ("settlementMode".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetSettlementMode(value);
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
		
		
		public void Write(PurchaseOrderQueryModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetQueryNo() != null) {
				
				oprot.WriteFieldBegin("queryNo");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetQueryNo()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("queryNo can not be null!");
			}
			
			
			if(structs.GetQueryType() != null) {
				
				oprot.WriteFieldBegin("queryType");
				oprot.WriteI64((long)structs.GetQueryType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("queryType can not be null!");
			}
			
			
			if(structs.GetCompanyCode() != null) {
				
				oprot.WriteFieldBegin("companyCode");
				oprot.WriteString(structs.GetCompanyCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVisibility() != null) {
				
				oprot.WriteFieldBegin("visibility");
				oprot.WriteI64((long)structs.GetVisibility()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("visibility can not be null!");
			}
			
			
			if(structs.GetApprovalStatus() != null) {
				
				oprot.WriteFieldBegin("approvalStatus");
				oprot.WriteByte((byte)structs.GetApprovalStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDeliveryStatus() != null) {
				
				oprot.WriteFieldBegin("deliveryStatus");
				oprot.WriteByte((byte)structs.GetDeliveryStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStockProps() != null) {
				
				oprot.WriteFieldBegin("stockProps");
				oprot.WriteByte((byte)structs.GetStockProps()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDeliveryWarehouse() != null) {
				
				oprot.WriteFieldBegin("deliveryWarehouse");
				oprot.WriteString(structs.GetDeliveryWarehouse());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreateTimeStart() != null) {
				
				oprot.WriteFieldBegin("createTimeStart");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetCreateTimeStart())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPageSize() != null) {
				
				oprot.WriteFieldBegin("pageSize");
				oprot.WriteI32((int)structs.GetPageSize()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPage() != null) {
				
				oprot.WriteFieldBegin("page");
				oprot.WriteI32((int)structs.GetPage()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyerId() != null) {
				
				oprot.WriteFieldBegin("buyerId");
				oprot.WriteString(structs.GetBuyerId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreateTimeEnd() != null) {
				
				oprot.WriteFieldBegin("createTimeEnd");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetCreateTimeEnd())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendorCode() != null) {
				
				oprot.WriteFieldBegin("vendorCode");
				oprot.WriteString(structs.GetVendorCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendorName() != null) {
				
				oprot.WriteFieldBegin("vendorName");
				oprot.WriteString(structs.GetVendorName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchaseType() != null) {
				
				oprot.WriteFieldBegin("purchaseType");
				oprot.WriteString(structs.GetPurchaseType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetApprovalRole() != null) {
				
				oprot.WriteFieldBegin("approvalRole");
				oprot.WriteString(structs.GetApprovalRole());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBarcodeType() != null) {
				
				oprot.WriteFieldBegin("barcodeType");
				oprot.WriteByte((byte)structs.GetBarcodeType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBarcodes() != null) {
				
				oprot.WriteFieldBegin("barcodes");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetBarcodes()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGoodsType() != null) {
				
				oprot.WriteFieldBegin("goodsType");
				oprot.WriteByte((byte)structs.GetGoodsType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSource() != null) {
				
				oprot.WriteFieldBegin("source");
				oprot.WriteString(structs.GetSource());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCooperationMode() != null) {
				
				oprot.WriteFieldBegin("cooperationMode");
				oprot.WriteByte((byte)structs.GetCooperationMode()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGoodsChannel() != null) {
				
				oprot.WriteFieldBegin("goodsChannel");
				oprot.WriteString(structs.GetGoodsChannel());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReceivingType() != null) {
				
				oprot.WriteFieldBegin("receivingType");
				oprot.WriteByte((byte)structs.GetReceivingType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReceiveWarehouseCode() != null) {
				
				oprot.WriteFieldBegin("receiveWarehouseCode");
				oprot.WriteString(structs.GetReceiveWarehouseCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSettlementMode() != null) {
				
				oprot.WriteFieldBegin("settlementMode");
				oprot.WriteByte((byte)structs.GetSettlementMode()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PurchaseOrderQueryModel bean){
			
			
		}
		
	}
	
}