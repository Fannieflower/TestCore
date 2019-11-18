using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.venus.visPo.service{
	
	
	
	public class EBSPoDetailHelper : TBeanSerializer<EBSPoDetail>
	{
		
		public static EBSPoDetailHelper OBJ = new EBSPoDetailHelper();
		
		public static EBSPoDetailHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(EBSPoDetail structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("sourceCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSourceCode(value);
					}
					
					
					
					
					
					if ("vendorCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVendorCode(value);
					}
					
					
					
					
					
					if ("buyerBy".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyerBy(value);
					}
					
					
					
					
					
					if ("purchaseType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchaseType(value);
					}
					
					
					
					
					
					if ("lineNum".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLineNum(value);
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
					
					
					
					
					
					if ("uomCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUomCode(value);
					}
					
					
					
					
					
					if ("poQty".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPoQty(value);
					}
					
					
					
					
					
					if ("packingQty".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPackingQty(value);
					}
					
					
					
					
					
					if ("poMarketPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPoMarketPrice(value);
					}
					
					
					
					
					
					if ("poUnitPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPoUnitPrice(value);
					}
					
					
					
					
					
					if ("needByDate".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetNeedByDate(value);
					}
					
					
					
					
					
					if ("sellArea".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSellArea(value);
					}
					
					
					
					
					
					if ("settlement".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSettlement(value);
					}
					
					
					
					
					
					if ("purchaseModel".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchaseModel(value);
					}
					
					
					
					
					
					if ("currency".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCurrency(value);
					}
					
					
					
					
					
					if ("rateDate".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRateDate(value);
					}
					
					
					
					
					
					if ("tradeModel".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTradeModel(value);
					}
					
					
					
					
					
					if ("po".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPo(value);
					}
					
					
					
					
					
					if ("createdBy".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCreatedBy(value);
					}
					
					
					
					
					
					if ("creationDate".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCreationDate(value);
					}
					
					
					
					
					
					if ("lastUpdatedBy".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLastUpdatedBy(value);
					}
					
					
					
					
					
					if ("lastUpdateDate".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLastUpdateDate(value);
					}
					
					
					
					
					
					if ("servfeeRate".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetServfeeRate(value);
					}
					
					
					
					
					
					if ("delayDays".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDelayDays(value);
					}
					
					
					
					
					
					if ("tagPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTagPrice(value);
					}
					
					
					
					
					
					if ("purchaseArea".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchaseArea(value);
					}
					
					
					
					
					
					if ("purchaseOffice".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchaseOffice(value);
					}
					
					
					
					
					
					if ("taxPurchasePrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTaxPurchasePrice(value);
					}
					
					
					
					
					
					if ("size".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSize(value);
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
					
					
					
					
					
					if ("brandNameEn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandNameEn(value);
					}
					
					
					
					
					
					if ("itemSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetItemSn(value);
					}
					
					
					
					
					
					if ("buyerName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyerName(value);
					}
					
					
					
					
					
					if ("taxRate".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTaxRate(value);
					}
					
					
					
					
					
					if ("purchaseOffice1".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchaseOffice1(value);
					}
					
					
					
					
					
					if ("kpiDays".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetKpiDays(value);
					}
					
					
					
					
					
					if ("kpiGrossMargin".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetKpiGrossMargin(value);
					}
					
					
					
					
					
					if ("salesSite".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSalesSite(value);
					}
					
					
					
					
					
					if ("generalTrade".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetGeneralTrade(value);
					}
					
					
					
					
					
					if ("pdcVendorCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPdcVendorCode(value);
					}
					
					
					
					
					
					if ("taxType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTaxType(value);
					}
					
					
					
					
					
					if ("taxTypeRate".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTaxTypeRate(value);
					}
					
					
					
					
					
					if ("purchaseCompany".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchaseCompany(value);
					}
					
					
					
					
					
					if ("purchaseCompanyCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchaseCompanyCode(value);
					}
					
					
					
					
					
					if ("originalPo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOriginalPo(value);
					}
					
					
					
					
					
					if ("partyCountry".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPartyCountry(value);
					}
					
					
					
					
					
					if ("isVWarehouse".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsVWarehouse(value);
					}
					
					
					
					
					
					if ("productionDate".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetProductionDate(value);
					}
					
					
					
					
					
					if ("expireDate".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetExpireDate(value);
					}
					
					
					
					
					
					if ("SETTLE_SEGMENT1".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSETTLE_SEGMENT1(value);
					}
					
					
					
					
					
					if ("oldItemNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOldItemNo(value);
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
		
		
		public void Write(EBSPoDetail structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetSourceCode() != null) {
				
				oprot.WriteFieldBegin("sourceCode");
				oprot.WriteString(structs.GetSourceCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendorCode() != null) {
				
				oprot.WriteFieldBegin("vendorCode");
				oprot.WriteString(structs.GetVendorCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyerBy() != null) {
				
				oprot.WriteFieldBegin("buyerBy");
				oprot.WriteString(structs.GetBuyerBy());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchaseType() != null) {
				
				oprot.WriteFieldBegin("purchaseType");
				oprot.WriteString(structs.GetPurchaseType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLineNum() != null) {
				
				oprot.WriteFieldBegin("lineNum");
				oprot.WriteString(structs.GetLineNum());
				
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
			
			
			if(structs.GetUomCode() != null) {
				
				oprot.WriteFieldBegin("uomCode");
				oprot.WriteString(structs.GetUomCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPoQty() != null) {
				
				oprot.WriteFieldBegin("poQty");
				oprot.WriteString(structs.GetPoQty());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPackingQty() != null) {
				
				oprot.WriteFieldBegin("packingQty");
				oprot.WriteString(structs.GetPackingQty());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPoMarketPrice() != null) {
				
				oprot.WriteFieldBegin("poMarketPrice");
				oprot.WriteString(structs.GetPoMarketPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPoUnitPrice() != null) {
				
				oprot.WriteFieldBegin("poUnitPrice");
				oprot.WriteString(structs.GetPoUnitPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetNeedByDate() != null) {
				
				oprot.WriteFieldBegin("needByDate");
				oprot.WriteString(structs.GetNeedByDate());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSellArea() != null) {
				
				oprot.WriteFieldBegin("sellArea");
				oprot.WriteString(structs.GetSellArea());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSettlement() != null) {
				
				oprot.WriteFieldBegin("settlement");
				oprot.WriteString(structs.GetSettlement());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchaseModel() != null) {
				
				oprot.WriteFieldBegin("purchaseModel");
				oprot.WriteString(structs.GetPurchaseModel());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCurrency() != null) {
				
				oprot.WriteFieldBegin("currency");
				oprot.WriteString(structs.GetCurrency());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRateDate() != null) {
				
				oprot.WriteFieldBegin("rateDate");
				oprot.WriteString(structs.GetRateDate());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTradeModel() != null) {
				
				oprot.WriteFieldBegin("tradeModel");
				oprot.WriteString(structs.GetTradeModel());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPo() != null) {
				
				oprot.WriteFieldBegin("po");
				oprot.WriteString(structs.GetPo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreatedBy() != null) {
				
				oprot.WriteFieldBegin("createdBy");
				oprot.WriteString(structs.GetCreatedBy());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreationDate() != null) {
				
				oprot.WriteFieldBegin("creationDate");
				oprot.WriteString(structs.GetCreationDate());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLastUpdatedBy() != null) {
				
				oprot.WriteFieldBegin("lastUpdatedBy");
				oprot.WriteString(structs.GetLastUpdatedBy());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLastUpdateDate() != null) {
				
				oprot.WriteFieldBegin("lastUpdateDate");
				oprot.WriteString(structs.GetLastUpdateDate());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetServfeeRate() != null) {
				
				oprot.WriteFieldBegin("servfeeRate");
				oprot.WriteString(structs.GetServfeeRate());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDelayDays() != null) {
				
				oprot.WriteFieldBegin("delayDays");
				oprot.WriteString(structs.GetDelayDays());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTagPrice() != null) {
				
				oprot.WriteFieldBegin("tagPrice");
				oprot.WriteString(structs.GetTagPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchaseArea() != null) {
				
				oprot.WriteFieldBegin("purchaseArea");
				oprot.WriteString(structs.GetPurchaseArea());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchaseOffice() != null) {
				
				oprot.WriteFieldBegin("purchaseOffice");
				oprot.WriteString(structs.GetPurchaseOffice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTaxPurchasePrice() != null) {
				
				oprot.WriteFieldBegin("taxPurchasePrice");
				oprot.WriteString(structs.GetTaxPurchasePrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSize() != null) {
				
				oprot.WriteFieldBegin("size");
				oprot.WriteString(structs.GetSize());
				
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
			
			
			if(structs.GetBrandNameEn() != null) {
				
				oprot.WriteFieldBegin("brandNameEn");
				oprot.WriteString(structs.GetBrandNameEn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetItemSn() != null) {
				
				oprot.WriteFieldBegin("itemSn");
				oprot.WriteString(structs.GetItemSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyerName() != null) {
				
				oprot.WriteFieldBegin("buyerName");
				oprot.WriteString(structs.GetBuyerName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTaxRate() != null) {
				
				oprot.WriteFieldBegin("taxRate");
				oprot.WriteString(structs.GetTaxRate());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchaseOffice1() != null) {
				
				oprot.WriteFieldBegin("purchaseOffice1");
				oprot.WriteString(structs.GetPurchaseOffice1());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetKpiDays() != null) {
				
				oprot.WriteFieldBegin("kpiDays");
				oprot.WriteString(structs.GetKpiDays());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetKpiGrossMargin() != null) {
				
				oprot.WriteFieldBegin("kpiGrossMargin");
				oprot.WriteString(structs.GetKpiGrossMargin());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSalesSite() != null) {
				
				oprot.WriteFieldBegin("salesSite");
				oprot.WriteString(structs.GetSalesSite());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGeneralTrade() != null) {
				
				oprot.WriteFieldBegin("generalTrade");
				oprot.WriteString(structs.GetGeneralTrade());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPdcVendorCode() != null) {
				
				oprot.WriteFieldBegin("pdcVendorCode");
				oprot.WriteString(structs.GetPdcVendorCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTaxType() != null) {
				
				oprot.WriteFieldBegin("taxType");
				oprot.WriteString(structs.GetTaxType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTaxTypeRate() != null) {
				
				oprot.WriteFieldBegin("taxTypeRate");
				oprot.WriteString(structs.GetTaxTypeRate());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchaseCompany() != null) {
				
				oprot.WriteFieldBegin("purchaseCompany");
				oprot.WriteString(structs.GetPurchaseCompany());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchaseCompanyCode() != null) {
				
				oprot.WriteFieldBegin("purchaseCompanyCode");
				oprot.WriteString(structs.GetPurchaseCompanyCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOriginalPo() != null) {
				
				oprot.WriteFieldBegin("originalPo");
				oprot.WriteString(structs.GetOriginalPo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPartyCountry() != null) {
				
				oprot.WriteFieldBegin("partyCountry");
				oprot.WriteString(structs.GetPartyCountry());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsVWarehouse() != null) {
				
				oprot.WriteFieldBegin("isVWarehouse");
				oprot.WriteI32((int)structs.GetIsVWarehouse()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProductionDate() != null) {
				
				oprot.WriteFieldBegin("productionDate");
				oprot.WriteString(structs.GetProductionDate());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExpireDate() != null) {
				
				oprot.WriteFieldBegin("expireDate");
				oprot.WriteString(structs.GetExpireDate());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSETTLE_SEGMENT1() != null) {
				
				oprot.WriteFieldBegin("SETTLE_SEGMENT1");
				oprot.WriteString(structs.GetSETTLE_SEGMENT1());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOldItemNo() != null) {
				
				oprot.WriteFieldBegin("oldItemNo");
				oprot.WriteString(structs.GetOldItemNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(EBSPoDetail bean){
			
			
		}
		
	}
	
}