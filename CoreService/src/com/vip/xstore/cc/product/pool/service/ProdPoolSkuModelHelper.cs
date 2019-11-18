using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.cc.product.pool.service{
	
	
	
	public class ProdPoolSkuModelHelper : TBeanSerializer<ProdPoolSkuModel>
	{
		
		public static ProdPoolSkuModelHelper OBJ = new ProdPoolSkuModelHelper();
		
		public static ProdPoolSkuModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ProdPoolSkuModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("poNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPoNo(value);
					}
					
					
					
					
					
					if ("barcode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBarcode(value);
					}
					
					
					
					
					
					if ("grade".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetGrade(value);
					}
					
					
					
					
					
					if ("warehouseCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWarehouseCode(value);
					}
					
					
					
					
					
					if ("availableStock".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetAvailableStock(value);
					}
					
					
					
					
					
					if ("osn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOsn(value);
					}
					
					
					
					
					
					if ("sn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSn(value);
					}
					
					
					
					
					
					if ("age".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetAge(value);
					}
					
					
					
					
					
					if ("vSkuId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVSkuId(value);
					}
					
					
					
					
					
					if ("vSpuId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVSpuId(value);
					}
					
					
					
					
					
					if ("marketPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetMarketPrice(value);
					}
					
					
					
					
					
					if ("basePrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetBasePrice(value);
					}
					
					
					
					
					
					if ("vipPayPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetVipPayPrice(value);
					}
					
					
					
					
					
					if ("billTaxPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetBillTaxPrice(value);
					}
					
					
					
					
					
					if ("vendorCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVendorCode(value);
					}
					
					
					
					
					
					if ("mainImageUrl".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMainImageUrl(value);
					}
					
					
					
					
					
					if ("productName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetProductName(value);
					}
					
					
					
					
					
					if ("size".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSize(value);
					}
					
					
					
					
					
					if ("color".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetColor(value);
					}
					
					
					
					
					
					if ("brandSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandSn(value);
					}
					
					
					
					
					
					if ("brandName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandName(value);
					}
					
					
					
					
					
					if ("topCategoryId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTopCategoryId(value);
					}
					
					
					
					
					
					if ("topCategoryName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTopCategoryName(value);
					}
					
					
					
					
					
					if ("subCategoryId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSubCategoryId(value);
					}
					
					
					
					
					
					if ("subCategoryName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSubCategoryName(value);
					}
					
					
					
					
					
					if ("categoryId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCategoryId(value);
					}
					
					
					
					
					
					if ("categoryName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCategoryName(value);
					}
					
					
					
					
					
					if ("changeTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetChangeTime(value);
					}
					
					
					
					
					
					if ("xstoreBillTaxPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetXstoreBillTaxPrice(value);
					}
					
					
					
					
					
					if ("riAge".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetRiAge(value);
					}
					
					
					
					
					
					if ("salesPlanNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSalesPlanNo(value);
					}
					
					
					
					
					
					if ("seller".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetSeller(value);
					}
					
					
					
					
					
					if ("season".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSeason(value);
					}
					
					
					
					
					
					if ("poInTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPoInTime(value);
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
		
		
		public void Write(ProdPoolSkuModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPoNo() != null) {
				
				oprot.WriteFieldBegin("poNo");
				oprot.WriteString(structs.GetPoNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBarcode() != null) {
				
				oprot.WriteFieldBegin("barcode");
				oprot.WriteString(structs.GetBarcode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGrade() != null) {
				
				oprot.WriteFieldBegin("grade");
				oprot.WriteString(structs.GetGrade());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWarehouseCode() != null) {
				
				oprot.WriteFieldBegin("warehouseCode");
				oprot.WriteString(structs.GetWarehouseCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAvailableStock() != null) {
				
				oprot.WriteFieldBegin("availableStock");
				oprot.WriteI64((long)structs.GetAvailableStock()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOsn() != null) {
				
				oprot.WriteFieldBegin("osn");
				oprot.WriteString(structs.GetOsn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSn() != null) {
				
				oprot.WriteFieldBegin("sn");
				oprot.WriteString(structs.GetSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAge() != null) {
				
				oprot.WriteFieldBegin("age");
				oprot.WriteI32((int)structs.GetAge()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVSkuId() != null) {
				
				oprot.WriteFieldBegin("vSkuId");
				oprot.WriteString(structs.GetVSkuId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVSpuId() != null) {
				
				oprot.WriteFieldBegin("vSpuId");
				oprot.WriteString(structs.GetVSpuId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMarketPrice() != null) {
				
				oprot.WriteFieldBegin("marketPrice");
				oprot.WriteDouble((double)structs.GetMarketPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBasePrice() != null) {
				
				oprot.WriteFieldBegin("basePrice");
				oprot.WriteDouble((double)structs.GetBasePrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVipPayPrice() != null) {
				
				oprot.WriteFieldBegin("vipPayPrice");
				oprot.WriteDouble((double)structs.GetVipPayPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBillTaxPrice() != null) {
				
				oprot.WriteFieldBegin("billTaxPrice");
				oprot.WriteDouble((double)structs.GetBillTaxPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendorCode() != null) {
				
				oprot.WriteFieldBegin("vendorCode");
				oprot.WriteString(structs.GetVendorCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMainImageUrl() != null) {
				
				oprot.WriteFieldBegin("mainImageUrl");
				oprot.WriteString(structs.GetMainImageUrl());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProductName() != null) {
				
				oprot.WriteFieldBegin("productName");
				oprot.WriteString(structs.GetProductName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSize() != null) {
				
				oprot.WriteFieldBegin("size");
				oprot.WriteString(structs.GetSize());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetColor() != null) {
				
				oprot.WriteFieldBegin("color");
				oprot.WriteString(structs.GetColor());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandSn() != null) {
				
				oprot.WriteFieldBegin("brandSn");
				oprot.WriteString(structs.GetBrandSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandName() != null) {
				
				oprot.WriteFieldBegin("brandName");
				oprot.WriteString(structs.GetBrandName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTopCategoryId() != null) {
				
				oprot.WriteFieldBegin("topCategoryId");
				oprot.WriteString(structs.GetTopCategoryId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTopCategoryName() != null) {
				
				oprot.WriteFieldBegin("topCategoryName");
				oprot.WriteString(structs.GetTopCategoryName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSubCategoryId() != null) {
				
				oprot.WriteFieldBegin("subCategoryId");
				oprot.WriteString(structs.GetSubCategoryId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSubCategoryName() != null) {
				
				oprot.WriteFieldBegin("subCategoryName");
				oprot.WriteString(structs.GetSubCategoryName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCategoryId() != null) {
				
				oprot.WriteFieldBegin("categoryId");
				oprot.WriteString(structs.GetCategoryId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCategoryName() != null) {
				
				oprot.WriteFieldBegin("categoryName");
				oprot.WriteString(structs.GetCategoryName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetChangeTime() != null) {
				
				oprot.WriteFieldBegin("changeTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetChangeTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetXstoreBillTaxPrice() != null) {
				
				oprot.WriteFieldBegin("xstoreBillTaxPrice");
				oprot.WriteDouble((double)structs.GetXstoreBillTaxPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRiAge() != null) {
				
				oprot.WriteFieldBegin("riAge");
				oprot.WriteI32((int)structs.GetRiAge()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSalesPlanNo() != null) {
				
				oprot.WriteFieldBegin("salesPlanNo");
				oprot.WriteString(structs.GetSalesPlanNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSeller() != null) {
				
				oprot.WriteFieldBegin("seller");
				oprot.WriteByte((byte)structs.GetSeller()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSeason() != null) {
				
				oprot.WriteFieldBegin("season");
				oprot.WriteString(structs.GetSeason());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPoInTime() != null) {
				
				oprot.WriteFieldBegin("poInTime");
				oprot.WriteString(structs.GetPoInTime());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ProdPoolSkuModel bean){
			
			
		}
		
	}
	
}