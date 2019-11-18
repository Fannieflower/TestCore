using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.fcs.ap.service{
	
	
	
	public class VendorBillDiscountSourceHelper : TBeanSerializer<VendorBillDiscountSource>
	{
		
		public static VendorBillDiscountSourceHelper OBJ = new VendorBillDiscountSourceHelper();
		
		public static VendorBillDiscountSourceHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(VendorBillDiscountSource structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("vendorId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetVendorId(value);
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
					
					
					
					
					
					if ("orgId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrgId(value);
					}
					
					
					
					
					
					if ("orgName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrgName(value);
					}
					
					
					
					
					
					if ("warehouse".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWarehouse(value);
					}
					
					
					
					
					
					if ("scheduleId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetScheduleId(value);
					}
					
					
					
					
					
					if ("scheduleName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetScheduleName(value);
					}
					
					
					
					
					
					if ("brandId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandId(value);
					}
					
					
					
					
					
					if ("vBrandName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVBrandName(value);
					}
					
					
					
					
					
					if ("poNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPoNo(value);
					}
					
					
					
					
					
					if ("poCreationDate".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPoCreationDate(value);
					}
					
					
					
					
					
					if ("origPoNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrigPoNo(value);
					}
					
					
					
					
					
					if ("orderNum".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderNum(value);
					}
					
					
					
					
					
					if ("orderDate".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderDate(value);
					}
					
					
					
					
					
					if ("itemNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetItemNo(value);
					}
					
					
					
					
					
					if ("itemDescription".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetItemDescription(value);
					}
					
					
					
					
					
					if ("goodsNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetGoodsNo(value);
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
					
					
					
					
					
					if ("transactionQuantity".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetTransactionQuantity(value);
					}
					
					
					
					
					
					if ("dataSign".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetDataSign(value);
					}
					
					
					
					
					
					if ("orderPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderPrice(value);
					}
					
					
					
					
					
					if ("currencyCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCurrencyCode(value);
					}
					
					
					
					
					
					if ("taxRate".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTaxRate(value);
					}
					
					
					
					
					
					if ("periodName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPeriodName(value);
					}
					
					
					
					
					
					if ("transactionTypeId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransactionTypeId(value);
					}
					
					
					
					
					
					if ("transactionDate".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetTransactionDate(value);
					}
					
					
					
					
					
					if ("payableBillAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetPayableBillAmount(value);
					}
					
					
					
					
					
					if ("vendorRate".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetVendorRate(value);
					}
					
					
					
					
					
					if ("confirmNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetConfirmNo(value);
					}
					
					
					
					
					
					if ("salePlatform".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSalePlatform(value);
					}
					
					
					
					
					
					if ("salePlatformName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSalePlatformName(value);
					}
					
					
					
					
					
					if ("createdTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetCreatedTime(value);
					}
					
					
					
					
					
					if ("updatedTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetUpdatedTime(value);
					}
					
					
					
					
					
					if ("isDeleted".Equals(schemeField.Trim())){
						
						needSkip = false;
						short? value;
						value = iprot.ReadI16(); 
						
						structs.SetIsDeleted(value);
					}
					
					
					
					
					
					if ("grossMarginRate".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetGrossMarginRate(value);
					}
					
					
					
					
					
					if ("remark".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRemark(value);
					}
					
					
					
					
					
					if ("poPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetPoPrice(value);
					}
					
					
					
					
					
					if ("poTaxPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetPoTaxPrice(value);
					}
					
					
					
					
					
					if ("payableTotalBillAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetPayableTotalBillAmount(value);
					}
					
					
					
					
					
					if ("detailLineType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDetailLineType(value);
					}
					
					
					
					
					
					if ("sourceId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetSourceId(value);
					}
					
					
					
					
					
					if ("activeType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetActiveType(value);
					}
					
					
					
					
					
					if ("activeTypeName".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetActiveTypeName(value);
					}
					
					
					
					
					
					if ("actParentNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetActParentNo(value);
					}
					
					
					
					
					
					if ("actParentName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetActParentName(value);
					}
					
					
					
					
					
					if ("discountLevel".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDiscountLevel(value);
					}
					
					
					
					
					
					if ("redPacketValue".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetRedPacketValue(value);
					}
					
					
					
					
					
					if ("activeBeginTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetActiveBeginTime(value);
					}
					
					
					
					
					
					if ("billAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetBillAmount(value);
					}
					
					
					
					
					
					if ("totalBillAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetTotalBillAmount(value);
					}
					
					
					
					
					
					if ("favPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetFavPrice(value);
					}
					
					
					
					
					
					if ("totalAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetTotalAmount(value);
					}
					
					
					
					
					
					if ("vendorRedpacketCount".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetVendorRedpacketCount(value);
					}
					
					
					
					
					
					if ("enterTotalBillAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetEnterTotalBillAmount(value);
					}
					
					
					
					
					
					if ("enterPayableTotalBillAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetEnterPayableTotalBillAmount(value);
					}
					
					
					
					
					
					if ("masterScheduleId".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetMasterScheduleId(value);
					}
					
					
					
					
					
					if ("sourceOrderNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetSourceOrderNo(value);
					}
					
					
					
					
					
					if ("sourceTotalAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetSourceTotalAmount(value);
					}
					
					
					
					
					
					if ("sourceTotalDiscountAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetSourceTotalDiscountAmount(value);
					}
					
					
					
					
					
					if ("businessType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBusinessType(value);
					}
					
					
					
					
					
					if ("processingType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetProcessingType(value);
					}
					
					
					
					
					
					if ("referenceBillNumber".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReferenceBillNumber(value);
					}
					
					
					
					
					
					if ("transactionType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransactionType(value);
					}
					
					
					
					
					
					if ("transactionTypeName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransactionTypeName(value);
					}
					
					
					
					
					
					if ("billType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBillType(value);
					}
					
					
					
					
					
					if ("discountConversionRate".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDiscountConversionRate(value);
					}
					
					
					
					
					
					if ("salesChannel".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSalesChannel(value);
					}
					
					
					
					
					
					if ("orderStatus".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderStatus(value);
					}
					
					
					
					
					
					if ("invPo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetInvPo(value);
					}
					
					
					
					
					
					if ("grossMargin".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetGrossMargin(value);
					}
					
					
					
					
					
					if ("invGlobalId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetInvGlobalId(value);
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
		
		
		public void Write(VendorBillDiscountSource structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetGlobalId() != null) {
				
				oprot.WriteFieldBegin("globalId");
				oprot.WriteI64((long)structs.GetGlobalId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendorId() != null) {
				
				oprot.WriteFieldBegin("vendorId");
				oprot.WriteI64((long)structs.GetVendorId()); 
				
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
			
			
			if(structs.GetOrgId() != null) {
				
				oprot.WriteFieldBegin("orgId");
				oprot.WriteString(structs.GetOrgId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrgName() != null) {
				
				oprot.WriteFieldBegin("orgName");
				oprot.WriteString(structs.GetOrgName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWarehouse() != null) {
				
				oprot.WriteFieldBegin("warehouse");
				oprot.WriteString(structs.GetWarehouse());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetScheduleId() != null) {
				
				oprot.WriteFieldBegin("scheduleId");
				oprot.WriteString(structs.GetScheduleId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetScheduleName() != null) {
				
				oprot.WriteFieldBegin("scheduleName");
				oprot.WriteString(structs.GetScheduleName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandId() != null) {
				
				oprot.WriteFieldBegin("brandId");
				oprot.WriteString(structs.GetBrandId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVBrandName() != null) {
				
				oprot.WriteFieldBegin("vBrandName");
				oprot.WriteString(structs.GetVBrandName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPoNo() != null) {
				
				oprot.WriteFieldBegin("poNo");
				oprot.WriteString(structs.GetPoNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPoCreationDate() != null) {
				
				oprot.WriteFieldBegin("poCreationDate");
				oprot.WriteString(structs.GetPoCreationDate());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrigPoNo() != null) {
				
				oprot.WriteFieldBegin("origPoNo");
				oprot.WriteString(structs.GetOrigPoNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderNum() != null) {
				
				oprot.WriteFieldBegin("orderNum");
				oprot.WriteString(structs.GetOrderNum());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderDate() != null) {
				
				oprot.WriteFieldBegin("orderDate");
				oprot.WriteString(structs.GetOrderDate());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetItemNo() != null) {
				
				oprot.WriteFieldBegin("itemNo");
				oprot.WriteString(structs.GetItemNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetItemDescription() != null) {
				
				oprot.WriteFieldBegin("itemDescription");
				oprot.WriteString(structs.GetItemDescription());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGoodsNo() != null) {
				
				oprot.WriteFieldBegin("goodsNo");
				oprot.WriteString(structs.GetGoodsNo());
				
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
			
			
			if(structs.GetTransactionQuantity() != null) {
				
				oprot.WriteFieldBegin("transactionQuantity");
				oprot.WriteDouble((double)structs.GetTransactionQuantity());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDataSign() != null) {
				
				oprot.WriteFieldBegin("dataSign");
				oprot.WriteI32((int)structs.GetDataSign()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderPrice() != null) {
				
				oprot.WriteFieldBegin("orderPrice");
				oprot.WriteString(structs.GetOrderPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCurrencyCode() != null) {
				
				oprot.WriteFieldBegin("currencyCode");
				oprot.WriteString(structs.GetCurrencyCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTaxRate() != null) {
				
				oprot.WriteFieldBegin("taxRate");
				oprot.WriteString(structs.GetTaxRate());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPeriodName() != null) {
				
				oprot.WriteFieldBegin("periodName");
				oprot.WriteString(structs.GetPeriodName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransactionTypeId() != null) {
				
				oprot.WriteFieldBegin("transactionTypeId");
				oprot.WriteString(structs.GetTransactionTypeId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransactionDate() != null) {
				
				oprot.WriteFieldBegin("transactionDate");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetTransactionDate())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPayableBillAmount() != null) {
				
				oprot.WriteFieldBegin("payableBillAmount");
				oprot.WriteDouble((double)structs.GetPayableBillAmount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendorRate() != null) {
				
				oprot.WriteFieldBegin("vendorRate");
				oprot.WriteDouble((double)structs.GetVendorRate());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetConfirmNo() != null) {
				
				oprot.WriteFieldBegin("confirmNo");
				oprot.WriteString(structs.GetConfirmNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSalePlatform() != null) {
				
				oprot.WriteFieldBegin("salePlatform");
				oprot.WriteString(structs.GetSalePlatform());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSalePlatformName() != null) {
				
				oprot.WriteFieldBegin("salePlatformName");
				oprot.WriteString(structs.GetSalePlatformName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreatedTime() != null) {
				
				oprot.WriteFieldBegin("createdTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetCreatedTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUpdatedTime() != null) {
				
				oprot.WriteFieldBegin("updatedTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetUpdatedTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsDeleted() != null) {
				
				oprot.WriteFieldBegin("isDeleted");
				oprot.WriteI16((short)structs.GetIsDeleted()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGrossMarginRate() != null) {
				
				oprot.WriteFieldBegin("grossMarginRate");
				oprot.WriteString(structs.GetGrossMarginRate());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRemark() != null) {
				
				oprot.WriteFieldBegin("remark");
				oprot.WriteString(structs.GetRemark());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPoPrice() != null) {
				
				oprot.WriteFieldBegin("poPrice");
				oprot.WriteDouble((double)structs.GetPoPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPoTaxPrice() != null) {
				
				oprot.WriteFieldBegin("poTaxPrice");
				oprot.WriteDouble((double)structs.GetPoTaxPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPayableTotalBillAmount() != null) {
				
				oprot.WriteFieldBegin("payableTotalBillAmount");
				oprot.WriteDouble((double)structs.GetPayableTotalBillAmount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDetailLineType() != null) {
				
				oprot.WriteFieldBegin("detailLineType");
				oprot.WriteString(structs.GetDetailLineType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSourceId() != null) {
				
				oprot.WriteFieldBegin("sourceId");
				oprot.WriteI64((long)structs.GetSourceId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetActiveType() != null) {
				
				oprot.WriteFieldBegin("activeType");
				oprot.WriteString(structs.GetActiveType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetActiveTypeName() != null) {
				
				oprot.WriteFieldBegin("activeTypeName");
				oprot.WriteI64((long)structs.GetActiveTypeName()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetActParentNo() != null) {
				
				oprot.WriteFieldBegin("actParentNo");
				oprot.WriteString(structs.GetActParentNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetActParentName() != null) {
				
				oprot.WriteFieldBegin("actParentName");
				oprot.WriteString(structs.GetActParentName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDiscountLevel() != null) {
				
				oprot.WriteFieldBegin("discountLevel");
				oprot.WriteString(structs.GetDiscountLevel());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRedPacketValue() != null) {
				
				oprot.WriteFieldBegin("redPacketValue");
				oprot.WriteDouble((double)structs.GetRedPacketValue());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetActiveBeginTime() != null) {
				
				oprot.WriteFieldBegin("activeBeginTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetActiveBeginTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBillAmount() != null) {
				
				oprot.WriteFieldBegin("billAmount");
				oprot.WriteDouble((double)structs.GetBillAmount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTotalBillAmount() != null) {
				
				oprot.WriteFieldBegin("totalBillAmount");
				oprot.WriteDouble((double)structs.GetTotalBillAmount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFavPrice() != null) {
				
				oprot.WriteFieldBegin("favPrice");
				oprot.WriteDouble((double)structs.GetFavPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTotalAmount() != null) {
				
				oprot.WriteFieldBegin("totalAmount");
				oprot.WriteDouble((double)structs.GetTotalAmount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendorRedpacketCount() != null) {
				
				oprot.WriteFieldBegin("vendorRedpacketCount");
				oprot.WriteI64((long)structs.GetVendorRedpacketCount()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetEnterTotalBillAmount() != null) {
				
				oprot.WriteFieldBegin("enterTotalBillAmount");
				oprot.WriteI64((long)structs.GetEnterTotalBillAmount()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetEnterPayableTotalBillAmount() != null) {
				
				oprot.WriteFieldBegin("enterPayableTotalBillAmount");
				oprot.WriteDouble((double)structs.GetEnterPayableTotalBillAmount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMasterScheduleId() != null) {
				
				oprot.WriteFieldBegin("masterScheduleId");
				oprot.WriteDouble((double)structs.GetMasterScheduleId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSourceOrderNo() != null) {
				
				oprot.WriteFieldBegin("sourceOrderNo");
				oprot.WriteDouble((double)structs.GetSourceOrderNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSourceTotalAmount() != null) {
				
				oprot.WriteFieldBegin("sourceTotalAmount");
				oprot.WriteDouble((double)structs.GetSourceTotalAmount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSourceTotalDiscountAmount() != null) {
				
				oprot.WriteFieldBegin("sourceTotalDiscountAmount");
				oprot.WriteDouble((double)structs.GetSourceTotalDiscountAmount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBusinessType() != null) {
				
				oprot.WriteFieldBegin("businessType");
				oprot.WriteString(structs.GetBusinessType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProcessingType() != null) {
				
				oprot.WriteFieldBegin("processingType");
				oprot.WriteString(structs.GetProcessingType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReferenceBillNumber() != null) {
				
				oprot.WriteFieldBegin("referenceBillNumber");
				oprot.WriteString(structs.GetReferenceBillNumber());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransactionType() != null) {
				
				oprot.WriteFieldBegin("transactionType");
				oprot.WriteString(structs.GetTransactionType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransactionTypeName() != null) {
				
				oprot.WriteFieldBegin("transactionTypeName");
				oprot.WriteString(structs.GetTransactionTypeName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBillType() != null) {
				
				oprot.WriteFieldBegin("billType");
				oprot.WriteString(structs.GetBillType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDiscountConversionRate() != null) {
				
				oprot.WriteFieldBegin("discountConversionRate");
				oprot.WriteString(structs.GetDiscountConversionRate());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSalesChannel() != null) {
				
				oprot.WriteFieldBegin("salesChannel");
				oprot.WriteString(structs.GetSalesChannel());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderStatus() != null) {
				
				oprot.WriteFieldBegin("orderStatus");
				oprot.WriteString(structs.GetOrderStatus());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInvPo() != null) {
				
				oprot.WriteFieldBegin("invPo");
				oprot.WriteString(structs.GetInvPo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGrossMargin() != null) {
				
				oprot.WriteFieldBegin("grossMargin");
				oprot.WriteString(structs.GetGrossMargin());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInvGlobalId() != null) {
				
				oprot.WriteFieldBegin("invGlobalId");
				oprot.WriteI64((long)structs.GetInvGlobalId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(VendorBillDiscountSource bean){
			
			
		}
		
	}
	
}