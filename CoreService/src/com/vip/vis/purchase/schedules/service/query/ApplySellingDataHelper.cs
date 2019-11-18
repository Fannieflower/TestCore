using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vis.purchase.schedules.service.query{
	
	
	
	public class ApplySellingDataHelper : TBeanSerializer<ApplySellingData>
	{
		
		public static ApplySellingDataHelper OBJ = new ApplySellingDataHelper();
		
		public static ApplySellingDataHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ApplySellingData structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("brandId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetBrandId(value);
					}
					
					
					
					
					
					if ("shopCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetShopCode(value);
					}
					
					
					
					
					
					if ("vendorCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetVendorCode(value);
					}
					
					
					
					
					
					if ("vendorName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVendorName(value);
					}
					
					
					
					
					
					if ("dataAreaId".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetDataAreaId(value);
					}
					
					
					
					
					
					if ("dataAreaName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDataAreaName(value);
					}
					
					
					
					
					
					if ("dataAreaDivide".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetDataAreaDivide(value);
					}
					
					
					
					
					
					if ("dataAreaDivideName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDataAreaDivideName(value);
					}
					
					
					
					
					
					if ("areaId".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetAreaId(value);
					}
					
					
					
					
					
					if ("departmentId".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetDepartmentId(value);
					}
					
					
					
					
					
					if ("departmentIdName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDepartmentIdName(value);
					}
					
					
					
					
					
					if ("createBy".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCreateBy(value);
					}
					
					
					
					
					
					if ("createByUid".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetCreateByUid(value);
					}
					
					
					
					
					
					if ("brandAdminName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandAdminName(value);
					}
					
					
					
					
					
					if ("brandAdminUserId".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetBrandAdminUserId(value);
					}
					
					
					
					
					
					if ("brandAdminUserJobnumber".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandAdminUserJobnumber(value);
					}
					
					
					
					
					
					if ("brandAdminDepName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandAdminDepName(value);
					}
					
					
					
					
					
					if ("sellingAction".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSellingAction(value);
					}
					
					
					
					
					
					if ("sellingMode".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetSellingMode(value);
					}
					
					
					
					
					
					if ("b2cModeId".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetB2cModeId(value);
					}
					
					
					
					
					
					if ("sellArea".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSellArea(value);
					}
					
					
					
					
					
					if ("distributionSites".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDistributionSites(value);
					}
					
					
					
					
					
					if ("sellTimeFromStr".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSellTimeFromStr(value);
					}
					
					
					
					
					
					if ("sellTimeToStr".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSellTimeToStr(value);
					}
					
					
					
					
					
					if ("isNormalization".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsNormalization(value);
					}
					
					
					
					
					
					if ("accessPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetAccessPrice(value);
					}
					
					
					
					
					
					if ("isPos".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetIsPos(value);
					}
					
					
					
					
					
					if ("exclusiveOrShare".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetExclusiveOrShare(value);
					}
					
					
					
					
					
					if ("specialOperationsFlag".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetSpecialOperationsFlag(value);
					}
					
					
					
					
					
					if ("brandList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vis.purchase.schedules.service.query.ApplyBrand> value;
						
						value = new List<com.vip.vis.purchase.schedules.service.query.ApplyBrand>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vis.purchase.schedules.service.query.ApplyBrand elem0;
								
								elem0 = new com.vip.vis.purchase.schedules.service.query.ApplyBrand();
								com.vip.vis.purchase.schedules.service.query.ApplyBrandHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetBrandList(value);
					}
					
					
					
					
					
					if ("labelList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								string elem2;
								elem2 = iprot.ReadString();
								
								value.Add(elem2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetLabelList(value);
					}
					
					
					
					
					
					if ("flagMap".Equals(schemeField.Trim())){
						
						needSkip = false;
						Dictionary<string, string> value;
						
						value = new Dictionary<string, string>();
						iprot.ReadMapBegin();
						while(true){
							
							try{
								
								string _key3;
								string _val3;
								_key3 = iprot.ReadString();
								
								_val3 = iprot.ReadString();
								
								value.Add(_key3, _val3);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadMapEnd();
						
						structs.SetFlagMap(value);
					}
					
					
					
					
					
					if ("department".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetDepartment(value);
					}
					
					
					
					
					
					if ("departmentName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDepartmentName(value);
					}
					
					
					
					
					
					if ("createByName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCreateByName(value);
					}
					
					
					
					
					
					if ("salePlatform".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSalePlatform(value);
					}
					
					
					
					
					
					if ("defectAttr".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetDefectAttr(value);
					}
					
					
					
					
					
					if ("createTimeStr".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCreateTimeStr(value);
					}
					
					
					
					
					
					if ("sellingModeReadable".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSellingModeReadable(value);
					}
					
					
					
					
					
					if ("isMarketPlace".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetIsMarketPlace(value);
					}
					
					
					
					
					
					if ("storeId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStoreId(value);
					}
					
					
					
					
					
					if ("isAreaSales".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetIsAreaSales(value);
					}
					
					
					
					
					
					if ("contractCurrency".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetContractCurrency(value);
					}
					
					
					
					
					
					if ("arrivalType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetArrivalType(value);
					}
					
					
					
					
					
					if ("paymentType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetPaymentType(value);
					}
					
					
					
					
					
					if ("isStoreSale".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetIsStoreSale(value);
					}
					
					
					
					
					
					if ("poCopyIntervalDay".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPoCopyIntervalDay(value);
					}
					
					
					
					
					
					if ("isHaopifa".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsHaopifa(value);
					}
					
					
					
					
					
					if ("defectAttrLevel".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetDefectAttrLevel(value);
					}
					
					
					
					
					
					if ("cooperationType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetCooperationType(value);
					}
					
					
					
					
					
					if ("isHt".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetIsHt(value);
					}
					
					
					
					
					
					if ("purchaseChannel".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								string elem4;
								elem4 = iprot.ReadString();
								
								value.Add(elem4);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetPurchaseChannel(value);
					}
					
					
					
					
					
					if ("grossProfitRate".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetGrossProfitRate(value);
					}
					
					
					
					
					
					if ("grossProfitRateEnd".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetGrossProfitRateEnd(value);
					}
					
					
					
					
					
					if ("grossProfitRateFixedValue".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetGrossProfitRateFixedValue(value);
					}
					
					
					
					
					
					if ("grossProfitRateLadderList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vis.purchase.schedules.service.query.GrossProfitRateLadder> value;
						
						value = new List<com.vip.vis.purchase.schedules.service.query.GrossProfitRateLadder>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vis.purchase.schedules.service.query.GrossProfitRateLadder elem5;
								
								elem5 = new com.vip.vis.purchase.schedules.service.query.GrossProfitRateLadder();
								com.vip.vis.purchase.schedules.service.query.GrossProfitRateLadderHelper.getInstance().Read(elem5, iprot);
								
								value.Add(elem5);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetGrossProfitRateLadderList(value);
					}
					
					
					
					
					
					if ("isPreSell".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsPreSell(value);
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
		
		
		public void Write(ApplySellingData structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetBrandId() != null) {
				
				oprot.WriteFieldBegin("brandId");
				oprot.WriteI64((long)structs.GetBrandId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetShopCode() != null) {
				
				oprot.WriteFieldBegin("shopCode");
				oprot.WriteI64((long)structs.GetShopCode()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendorCode() != null) {
				
				oprot.WriteFieldBegin("vendorCode");
				oprot.WriteI32((int)structs.GetVendorCode()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendorName() != null) {
				
				oprot.WriteFieldBegin("vendorName");
				oprot.WriteString(structs.GetVendorName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDataAreaId() != null) {
				
				oprot.WriteFieldBegin("dataAreaId");
				oprot.WriteI32((int)structs.GetDataAreaId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDataAreaName() != null) {
				
				oprot.WriteFieldBegin("dataAreaName");
				oprot.WriteString(structs.GetDataAreaName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDataAreaDivide() != null) {
				
				oprot.WriteFieldBegin("dataAreaDivide");
				oprot.WriteI32((int)structs.GetDataAreaDivide()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDataAreaDivideName() != null) {
				
				oprot.WriteFieldBegin("dataAreaDivideName");
				oprot.WriteString(structs.GetDataAreaDivideName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAreaId() != null) {
				
				oprot.WriteFieldBegin("areaId");
				oprot.WriteI32((int)structs.GetAreaId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDepartmentId() != null) {
				
				oprot.WriteFieldBegin("departmentId");
				oprot.WriteI32((int)structs.GetDepartmentId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDepartmentIdName() != null) {
				
				oprot.WriteFieldBegin("departmentIdName");
				oprot.WriteString(structs.GetDepartmentIdName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreateBy() != null) {
				
				oprot.WriteFieldBegin("createBy");
				oprot.WriteString(structs.GetCreateBy());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreateByUid() != null) {
				
				oprot.WriteFieldBegin("createByUid");
				oprot.WriteI32((int)structs.GetCreateByUid()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandAdminName() != null) {
				
				oprot.WriteFieldBegin("brandAdminName");
				oprot.WriteString(structs.GetBrandAdminName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandAdminUserId() != null) {
				
				oprot.WriteFieldBegin("brandAdminUserId");
				oprot.WriteI32((int)structs.GetBrandAdminUserId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandAdminUserJobnumber() != null) {
				
				oprot.WriteFieldBegin("brandAdminUserJobnumber");
				oprot.WriteString(structs.GetBrandAdminUserJobnumber());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandAdminDepName() != null) {
				
				oprot.WriteFieldBegin("brandAdminDepName");
				oprot.WriteString(structs.GetBrandAdminDepName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSellingAction() != null) {
				
				oprot.WriteFieldBegin("sellingAction");
				oprot.WriteString(structs.GetSellingAction());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSellingMode() != null) {
				
				oprot.WriteFieldBegin("sellingMode");
				oprot.WriteByte((byte)structs.GetSellingMode()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetB2cModeId() != null) {
				
				oprot.WriteFieldBegin("b2cModeId");
				oprot.WriteI32((int)structs.GetB2cModeId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSellArea() != null) {
				
				oprot.WriteFieldBegin("sellArea");
				oprot.WriteString(structs.GetSellArea());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDistributionSites() != null) {
				
				oprot.WriteFieldBegin("distributionSites");
				oprot.WriteString(structs.GetDistributionSites());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSellTimeFromStr() != null) {
				
				oprot.WriteFieldBegin("sellTimeFromStr");
				oprot.WriteString(structs.GetSellTimeFromStr());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSellTimeToStr() != null) {
				
				oprot.WriteFieldBegin("sellTimeToStr");
				oprot.WriteString(structs.GetSellTimeToStr());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsNormalization() != null) {
				
				oprot.WriteFieldBegin("isNormalization");
				oprot.WriteI32((int)structs.GetIsNormalization()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAccessPrice() != null) {
				
				oprot.WriteFieldBegin("accessPrice");
				oprot.WriteByte((byte)structs.GetAccessPrice()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsPos() != null) {
				
				oprot.WriteFieldBegin("isPos");
				oprot.WriteByte((byte)structs.GetIsPos()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExclusiveOrShare() != null) {
				
				oprot.WriteFieldBegin("exclusiveOrShare");
				oprot.WriteByte((byte)structs.GetExclusiveOrShare()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSpecialOperationsFlag() != null) {
				
				oprot.WriteFieldBegin("specialOperationsFlag");
				oprot.WriteByte((byte)structs.GetSpecialOperationsFlag()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandList() != null) {
				
				oprot.WriteFieldBegin("brandList");
				
				oprot.WriteListBegin();
				foreach(com.vip.vis.purchase.schedules.service.query.ApplyBrand _item0 in structs.GetBrandList()){
					
					
					com.vip.vis.purchase.schedules.service.query.ApplyBrandHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLabelList() != null) {
				
				oprot.WriteFieldBegin("labelList");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetLabelList()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFlagMap() != null) {
				
				oprot.WriteFieldBegin("flagMap");
				
				oprot.WriteMapBegin();
				foreach(KeyValuePair< string, string > _ir0 in structs.GetFlagMap()){
					
					string _key0 = _ir0.Key;
					string _value0 = _ir0.Value;
					oprot.WriteString(_key0);
					
					oprot.WriteString(_value0);
					
				}
				
				oprot.WriteMapEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDepartment() != null) {
				
				oprot.WriteFieldBegin("department");
				oprot.WriteI32((int)structs.GetDepartment()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDepartmentName() != null) {
				
				oprot.WriteFieldBegin("departmentName");
				oprot.WriteString(structs.GetDepartmentName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreateByName() != null) {
				
				oprot.WriteFieldBegin("createByName");
				oprot.WriteString(structs.GetCreateByName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSalePlatform() != null) {
				
				oprot.WriteFieldBegin("salePlatform");
				oprot.WriteString(structs.GetSalePlatform());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDefectAttr() != null) {
				
				oprot.WriteFieldBegin("defectAttr");
				oprot.WriteByte((byte)structs.GetDefectAttr()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreateTimeStr() != null) {
				
				oprot.WriteFieldBegin("createTimeStr");
				oprot.WriteString(structs.GetCreateTimeStr());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSellingModeReadable() != null) {
				
				oprot.WriteFieldBegin("sellingModeReadable");
				oprot.WriteString(structs.GetSellingModeReadable());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsMarketPlace() != null) {
				
				oprot.WriteFieldBegin("isMarketPlace");
				oprot.WriteByte((byte)structs.GetIsMarketPlace()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStoreId() != null) {
				
				oprot.WriteFieldBegin("storeId");
				oprot.WriteString(structs.GetStoreId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsAreaSales() != null) {
				
				oprot.WriteFieldBegin("isAreaSales");
				oprot.WriteByte((byte)structs.GetIsAreaSales()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetContractCurrency() != null) {
				
				oprot.WriteFieldBegin("contractCurrency");
				oprot.WriteString(structs.GetContractCurrency());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetArrivalType() != null) {
				
				oprot.WriteFieldBegin("arrivalType");
				oprot.WriteByte((byte)structs.GetArrivalType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPaymentType() != null) {
				
				oprot.WriteFieldBegin("paymentType");
				oprot.WriteByte((byte)structs.GetPaymentType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsStoreSale() != null) {
				
				oprot.WriteFieldBegin("isStoreSale");
				oprot.WriteByte((byte)structs.GetIsStoreSale()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPoCopyIntervalDay() != null) {
				
				oprot.WriteFieldBegin("poCopyIntervalDay");
				oprot.WriteI32((int)structs.GetPoCopyIntervalDay()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsHaopifa() != null) {
				
				oprot.WriteFieldBegin("isHaopifa");
				oprot.WriteI32((int)structs.GetIsHaopifa()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDefectAttrLevel() != null) {
				
				oprot.WriteFieldBegin("defectAttrLevel");
				oprot.WriteI32((int)structs.GetDefectAttrLevel()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCooperationType() != null) {
				
				oprot.WriteFieldBegin("cooperationType");
				oprot.WriteByte((byte)structs.GetCooperationType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsHt() != null) {
				
				oprot.WriteFieldBegin("isHt");
				oprot.WriteByte((byte)structs.GetIsHt()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchaseChannel() != null) {
				
				oprot.WriteFieldBegin("purchaseChannel");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetPurchaseChannel()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGrossProfitRate() != null) {
				
				oprot.WriteFieldBegin("grossProfitRate");
				oprot.WriteDouble((double)structs.GetGrossProfitRate());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGrossProfitRateEnd() != null) {
				
				oprot.WriteFieldBegin("grossProfitRateEnd");
				oprot.WriteDouble((double)structs.GetGrossProfitRateEnd());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGrossProfitRateFixedValue() != null) {
				
				oprot.WriteFieldBegin("grossProfitRateFixedValue");
				oprot.WriteDouble((double)structs.GetGrossProfitRateFixedValue());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGrossProfitRateLadderList() != null) {
				
				oprot.WriteFieldBegin("grossProfitRateLadderList");
				
				oprot.WriteListBegin();
				foreach(com.vip.vis.purchase.schedules.service.query.GrossProfitRateLadder _item0 in structs.GetGrossProfitRateLadderList()){
					
					
					com.vip.vis.purchase.schedules.service.query.GrossProfitRateLadderHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsPreSell() != null) {
				
				oprot.WriteFieldBegin("isPreSell");
				oprot.WriteI32((int)structs.GetIsPreSell()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ApplySellingData bean){
			
			
		}
		
	}
	
}