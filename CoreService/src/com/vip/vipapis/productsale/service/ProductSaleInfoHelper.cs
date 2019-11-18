using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vipapis.productsale.service{
	
	
	
	public class ProductSaleInfoHelper : TBeanSerializer<ProductSaleInfo>
	{
		
		public static ProductSaleInfoHelper OBJ = new ProductSaleInfoHelper();
		
		public static ProductSaleInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ProductSaleInfo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("globalId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetGlobalId(value);
					}
					
					
					
					
					
					if ("poOuName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPoOuName(value);
					}
					
					
					
					
					
					if ("vendorCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVendorCode(value);
					}
					
					
					
					
					
					if ("brandCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandCode(value);
					}
					
					
					
					
					
					if ("brandName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandName(value);
					}
					
					
					
					
					
					if ("orderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderSn(value);
					}
					
					
					
					
					
					if ("addTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAddTime(value);
					}
					
					
					
					
					
					if ("issueDate".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetIssueDate(value);
					}
					
					
					
					
					
					if ("status".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStatus(value);
					}
					
					
					
					
					
					if ("currencyCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCurrencyCode(value);
					}
					
					
					
					
					
					if ("sellingPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetSellingPrice(value);
					}
					
					
					
					
					
					if ("issueQuantity".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetIssueQuantity(value);
					}
					
					
					
					
					
					if ("itemNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetItemNo(value);
					}
					
					
					
					
					
					if ("itemDesc".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetItemDesc(value);
					}
					
					
					
					
					
					if ("orderAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetOrderAmount(value);
					}
					
					
					
					
					
					if ("moneyOver".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetMoneyOver(value);
					}
					
					
					
					
					
					if ("moneyDiscountLevel".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMoneyDiscountLevel(value);
					}
					
					
					
					
					
					if ("brandCut".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetBrandCut(value);
					}
					
					
					
					
					
					if ("brandDiscountLevel".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandDiscountLevel(value);
					}
					
					
					
					
					
					if ("zjAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetZjAmount(value);
					}
					
					
					
					
					
					if ("marketPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetMarketPrice(value);
					}
					
					
					
					
					
					if ("country".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCountry(value);
					}
					
					
					
					
					
					if ("province".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetProvince(value);
					}
					
					
					
					
					
					if ("city".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCity(value);
					}
					
					
					
					
					
					if ("warehouseName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWarehouseName(value);
					}
					
					
					
					
					
					if ("serialNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSerialNo(value);
					}
					
					
					
					
					
					if ("goodsActureAmt".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetGoodsActureAmt(value);
					}
					
					
					
					
					
					if ("rn".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetRn(value);
					}
					
					
					
					
					
					if ("createTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetCreateTime(value);
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
		
		
		public void Write(ProductSaleInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetGlobalId() != null) {
				
				oprot.WriteFieldBegin("globalId");
				oprot.WriteI64((long)structs.GetGlobalId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPoOuName() != null) {
				
				oprot.WriteFieldBegin("poOuName");
				oprot.WriteString(structs.GetPoOuName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendorCode() != null) {
				
				oprot.WriteFieldBegin("vendorCode");
				oprot.WriteString(structs.GetVendorCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandCode() != null) {
				
				oprot.WriteFieldBegin("brandCode");
				oprot.WriteString(structs.GetBrandCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandName() != null) {
				
				oprot.WriteFieldBegin("brandName");
				oprot.WriteString(structs.GetBrandName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderSn() != null) {
				
				oprot.WriteFieldBegin("orderSn");
				oprot.WriteString(structs.GetOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAddTime() != null) {
				
				oprot.WriteFieldBegin("addTime");
				oprot.WriteString(structs.GetAddTime());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIssueDate() != null) {
				
				oprot.WriteFieldBegin("issueDate");
				oprot.WriteI64((long)structs.GetIssueDate()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStatus() != null) {
				
				oprot.WriteFieldBegin("status");
				oprot.WriteString(structs.GetStatus());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCurrencyCode() != null) {
				
				oprot.WriteFieldBegin("currencyCode");
				oprot.WriteString(structs.GetCurrencyCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSellingPrice() != null) {
				
				oprot.WriteFieldBegin("sellingPrice");
				oprot.WriteDouble((double)structs.GetSellingPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIssueQuantity() != null) {
				
				oprot.WriteFieldBegin("issueQuantity");
				oprot.WriteDouble((double)structs.GetIssueQuantity());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetItemNo() != null) {
				
				oprot.WriteFieldBegin("itemNo");
				oprot.WriteString(structs.GetItemNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetItemDesc() != null) {
				
				oprot.WriteFieldBegin("itemDesc");
				oprot.WriteString(structs.GetItemDesc());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderAmount() != null) {
				
				oprot.WriteFieldBegin("orderAmount");
				oprot.WriteDouble((double)structs.GetOrderAmount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMoneyOver() != null) {
				
				oprot.WriteFieldBegin("moneyOver");
				oprot.WriteDouble((double)structs.GetMoneyOver());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMoneyDiscountLevel() != null) {
				
				oprot.WriteFieldBegin("moneyDiscountLevel");
				oprot.WriteString(structs.GetMoneyDiscountLevel());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandCut() != null) {
				
				oprot.WriteFieldBegin("brandCut");
				oprot.WriteDouble((double)structs.GetBrandCut());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandDiscountLevel() != null) {
				
				oprot.WriteFieldBegin("brandDiscountLevel");
				oprot.WriteString(structs.GetBrandDiscountLevel());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetZjAmount() != null) {
				
				oprot.WriteFieldBegin("zjAmount");
				oprot.WriteDouble((double)structs.GetZjAmount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMarketPrice() != null) {
				
				oprot.WriteFieldBegin("marketPrice");
				oprot.WriteDouble((double)structs.GetMarketPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCountry() != null) {
				
				oprot.WriteFieldBegin("country");
				oprot.WriteString(structs.GetCountry());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProvince() != null) {
				
				oprot.WriteFieldBegin("province");
				oprot.WriteString(structs.GetProvince());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCity() != null) {
				
				oprot.WriteFieldBegin("city");
				oprot.WriteString(structs.GetCity());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWarehouseName() != null) {
				
				oprot.WriteFieldBegin("warehouseName");
				oprot.WriteString(structs.GetWarehouseName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSerialNo() != null) {
				
				oprot.WriteFieldBegin("serialNo");
				oprot.WriteString(structs.GetSerialNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGoodsActureAmt() != null) {
				
				oprot.WriteFieldBegin("goodsActureAmt");
				oprot.WriteDouble((double)structs.GetGoodsActureAmt());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRn() != null) {
				
				oprot.WriteFieldBegin("rn");
				oprot.WriteI32((int)structs.GetRn()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreateTime() != null) {
				
				oprot.WriteFieldBegin("createTime");
				oprot.WriteI64((long)structs.GetCreateTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ProductSaleInfo bean){
			
			
		}
		
	}
	
}