using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	public class ProtContractMainInfoModelHelper : TBeanSerializer<ProtContractMainInfoModel>
	{
		
		public static ProtContractMainInfoModelHelper OBJ = new ProtContractMainInfoModelHelper();
		
		public static ProtContractMainInfoModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ProtContractMainInfoModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("id".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetId(value);
					}
					
					
					
					
					
					if ("protNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetProtNo(value);
					}
					
					
					
					
					
					if ("companyId".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetCompanyId(value);
					}
					
					
					
					
					
					if ("contractNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetContractNo(value);
					}
					
					
					
					
					
					if ("contractName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetContractName(value);
					}
					
					
					
					
					
					if ("contractTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetContractTime(value);
					}
					
					
					
					
					
					if ("signMode".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetSignMode(value);
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
					
					
					
					
					
					if ("specialName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSpecialName(value);
					}
					
					
					
					
					
					if ("rangeType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetRangeType(value);
					}
					
					
					
					
					
					if ("activityAlltype".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetActivityAlltype(value);
					}
					
					
					
					
					
					if ("onlineStarttime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetOnlineStarttime(value);
					}
					
					
					
					
					
					if ("onlineEndtime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetOnlineEndtime(value);
					}
					
					
					
					
					
					if ("basicStatus".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetBasicStatus(value);
					}
					
					
					
					
					
					if ("assistantStatus".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetAssistantStatus(value);
					}
					
					
					
					
					
					if ("managerStatus".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetManagerStatus(value);
					}
					
					
					
					
					
					if ("directorStatus".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetDirectorStatus(value);
					}
					
					
					
					
					
					if ("stage".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetStage(value);
					}
					
					
					
					
					
					if ("updateTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetUpdateTime(value);
					}
					
					
					
					
					
					if ("createTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetCreateTime(value);
					}
					
					
					
					
					
					if ("createBy".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCreateBy(value);
					}
					
					
					
					
					
					if ("departmentId".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetDepartmentId(value);
					}
					
					
					
					
					
					if ("acceptOperatorId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAcceptOperatorId(value);
					}
					
					
					
					
					
					if ("acceptOperator".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAcceptOperator(value);
					}
					
					
					
					
					
					if ("specialStatus".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetSpecialStatus(value);
					}
					
					
					
					
					
					if ("finalStatus".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetFinalStatus(value);
					}
					
					
					
					
					
					if ("brandName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandName(value);
					}
					
					
					
					
					
					if ("brandSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandSn(value);
					}
					
					
					
					
					
					if ("status".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetStatus(value);
					}
					
					
					
					
					
					if ("brandId".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetBrandId(value);
					}
					
					
					
					
					
					if ("departmentName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDepartmentName(value);
					}
					
					
					
					
					
					if ("scaleContent".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetScaleContent(value);
					}
					
					
					
					
					
					if ("discountContent".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDiscountContent(value);
					}
					
					
					
					
					
					if ("bindingType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetBindingType(value);
					}
					
					
					
					
					
					if ("operatorType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetOperatorType(value);
					}
					
					
					
					
					
					if ("businessType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetBusinessType(value);
					}
					
					
					
					
					
					if ("contractDimension".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetContractDimension(value);
					}
					
					
					
					
					
					if ("onlineStarttimeFmt".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOnlineStarttimeFmt(value);
					}
					
					
					
					
					
					if ("onlineEndtimeFmt".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOnlineEndtimeFmt(value);
					}
					
					
					
					
					
					if ("createTimeFmt".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCreateTimeFmt(value);
					}
					
					
					
					
					
					if ("contractDimensionName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetContractDimensionName(value);
					}
					
					
					
					
					
					if ("signModeName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSignModeName(value);
					}
					
					
					
					
					
					if ("statusName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStatusName(value);
					}
					
					
					
					
					
					if ("companyName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCompanyName(value);
					}
					
					
					
					
					
					if ("discountList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoModel> value;
						
						value = new List<com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoModel elem0;
								
								elem0 = new com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoModel();
								com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoModelHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetDiscountList(value);
					}
					
					
					
					
					
					if ("processCompletedTimeStr".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetProcessCompletedTimeStr(value);
					}
					
					
					
					
					
					if ("salesWarehouseList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.api.promotion.vis.protcontract.service.SalesWarehouse> value;
						
						value = new List<com.vip.api.promotion.vis.protcontract.service.SalesWarehouse>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.api.promotion.vis.protcontract.service.SalesWarehouse elem2;
								
								elem2 = new com.vip.api.promotion.vis.protcontract.service.SalesWarehouse();
								com.vip.api.promotion.vis.protcontract.service.SalesWarehouseHelper.getInstance().Read(elem2, iprot);
								
								value.Add(elem2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetSalesWarehouseList(value);
					}
					
					
					
					
					
					if ("overseasSalesType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetOverseasSalesType(value);
					}
					
					
					
					
					
					if ("salesNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetSalesNo(value);
					}
					
					
					
					
					
					if ("channel".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetChannel(value);
					}
					
					
					
					
					
					if ("contractMode".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetContractMode(value);
					}
					
					
					
					
					
					if ("oxoContractNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOxoContractNo(value);
					}
					
					
					
					
					
					if ("oxoContractName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOxoContractName(value);
					}
					
					
					
					
					
					if ("oxoContractTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetOxoContractTime(value);
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
		
		
		public void Write(ProtContractMainInfoModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetId() != null) {
				
				oprot.WriteFieldBegin("id");
				oprot.WriteI64((long)structs.GetId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProtNo() != null) {
				
				oprot.WriteFieldBegin("protNo");
				oprot.WriteString(structs.GetProtNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCompanyId() != null) {
				
				oprot.WriteFieldBegin("companyId");
				oprot.WriteI32((int)structs.GetCompanyId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetContractNo() != null) {
				
				oprot.WriteFieldBegin("contractNo");
				oprot.WriteString(structs.GetContractNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetContractName() != null) {
				
				oprot.WriteFieldBegin("contractName");
				oprot.WriteString(structs.GetContractName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetContractTime() != null) {
				
				oprot.WriteFieldBegin("contractTime");
				oprot.WriteI64((long)structs.GetContractTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSignMode() != null) {
				
				oprot.WriteFieldBegin("signMode");
				oprot.WriteByte((byte)structs.GetSignMode()); 
				
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
			
			
			if(structs.GetSpecialName() != null) {
				
				oprot.WriteFieldBegin("specialName");
				oprot.WriteString(structs.GetSpecialName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRangeType() != null) {
				
				oprot.WriteFieldBegin("rangeType");
				oprot.WriteByte((byte)structs.GetRangeType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetActivityAlltype() != null) {
				
				oprot.WriteFieldBegin("activityAlltype");
				oprot.WriteString(structs.GetActivityAlltype());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOnlineStarttime() != null) {
				
				oprot.WriteFieldBegin("onlineStarttime");
				oprot.WriteI64((long)structs.GetOnlineStarttime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOnlineEndtime() != null) {
				
				oprot.WriteFieldBegin("onlineEndtime");
				oprot.WriteI64((long)structs.GetOnlineEndtime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBasicStatus() != null) {
				
				oprot.WriteFieldBegin("basicStatus");
				oprot.WriteByte((byte)structs.GetBasicStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAssistantStatus() != null) {
				
				oprot.WriteFieldBegin("assistantStatus");
				oprot.WriteByte((byte)structs.GetAssistantStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetManagerStatus() != null) {
				
				oprot.WriteFieldBegin("managerStatus");
				oprot.WriteByte((byte)structs.GetManagerStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDirectorStatus() != null) {
				
				oprot.WriteFieldBegin("directorStatus");
				oprot.WriteByte((byte)structs.GetDirectorStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStage() != null) {
				
				oprot.WriteFieldBegin("stage");
				oprot.WriteByte((byte)structs.GetStage()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUpdateTime() != null) {
				
				oprot.WriteFieldBegin("updateTime");
				oprot.WriteI64((long)structs.GetUpdateTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreateTime() != null) {
				
				oprot.WriteFieldBegin("createTime");
				oprot.WriteI64((long)structs.GetCreateTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreateBy() != null) {
				
				oprot.WriteFieldBegin("createBy");
				oprot.WriteString(structs.GetCreateBy());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDepartmentId() != null) {
				
				oprot.WriteFieldBegin("departmentId");
				oprot.WriteI32((int)structs.GetDepartmentId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAcceptOperatorId() != null) {
				
				oprot.WriteFieldBegin("acceptOperatorId");
				oprot.WriteString(structs.GetAcceptOperatorId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAcceptOperator() != null) {
				
				oprot.WriteFieldBegin("acceptOperator");
				oprot.WriteString(structs.GetAcceptOperator());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSpecialStatus() != null) {
				
				oprot.WriteFieldBegin("specialStatus");
				oprot.WriteByte((byte)structs.GetSpecialStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFinalStatus() != null) {
				
				oprot.WriteFieldBegin("finalStatus");
				oprot.WriteByte((byte)structs.GetFinalStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandName() != null) {
				
				oprot.WriteFieldBegin("brandName");
				oprot.WriteString(structs.GetBrandName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandSn() != null) {
				
				oprot.WriteFieldBegin("brandSn");
				oprot.WriteString(structs.GetBrandSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStatus() != null) {
				
				oprot.WriteFieldBegin("status");
				oprot.WriteByte((byte)structs.GetStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandId() != null) {
				
				oprot.WriteFieldBegin("brandId");
				oprot.WriteI32((int)structs.GetBrandId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDepartmentName() != null) {
				
				oprot.WriteFieldBegin("departmentName");
				oprot.WriteString(structs.GetDepartmentName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetScaleContent() != null) {
				
				oprot.WriteFieldBegin("scaleContent");
				oprot.WriteString(structs.GetScaleContent());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDiscountContent() != null) {
				
				oprot.WriteFieldBegin("discountContent");
				oprot.WriteString(structs.GetDiscountContent());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBindingType() != null) {
				
				oprot.WriteFieldBegin("bindingType");
				oprot.WriteByte((byte)structs.GetBindingType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOperatorType() != null) {
				
				oprot.WriteFieldBegin("operatorType");
				oprot.WriteByte((byte)structs.GetOperatorType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBusinessType() != null) {
				
				oprot.WriteFieldBegin("businessType");
				oprot.WriteByte((byte)structs.GetBusinessType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetContractDimension() != null) {
				
				oprot.WriteFieldBegin("contractDimension");
				oprot.WriteByte((byte)structs.GetContractDimension()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOnlineStarttimeFmt() != null) {
				
				oprot.WriteFieldBegin("onlineStarttimeFmt");
				oprot.WriteString(structs.GetOnlineStarttimeFmt());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOnlineEndtimeFmt() != null) {
				
				oprot.WriteFieldBegin("onlineEndtimeFmt");
				oprot.WriteString(structs.GetOnlineEndtimeFmt());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreateTimeFmt() != null) {
				
				oprot.WriteFieldBegin("createTimeFmt");
				oprot.WriteString(structs.GetCreateTimeFmt());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetContractDimensionName() != null) {
				
				oprot.WriteFieldBegin("contractDimensionName");
				oprot.WriteString(structs.GetContractDimensionName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSignModeName() != null) {
				
				oprot.WriteFieldBegin("signModeName");
				oprot.WriteString(structs.GetSignModeName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStatusName() != null) {
				
				oprot.WriteFieldBegin("statusName");
				oprot.WriteString(structs.GetStatusName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCompanyName() != null) {
				
				oprot.WriteFieldBegin("companyName");
				oprot.WriteString(structs.GetCompanyName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDiscountList() != null) {
				
				oprot.WriteFieldBegin("discountList");
				
				oprot.WriteListBegin();
				foreach(com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoModel _item0 in structs.GetDiscountList()){
					
					
					com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProcessCompletedTimeStr() != null) {
				
				oprot.WriteFieldBegin("processCompletedTimeStr");
				oprot.WriteString(structs.GetProcessCompletedTimeStr());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSalesWarehouseList() != null) {
				
				oprot.WriteFieldBegin("salesWarehouseList");
				
				oprot.WriteListBegin();
				foreach(com.vip.api.promotion.vis.protcontract.service.SalesWarehouse _item0 in structs.GetSalesWarehouseList()){
					
					
					com.vip.api.promotion.vis.protcontract.service.SalesWarehouseHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOverseasSalesType() != null) {
				
				oprot.WriteFieldBegin("overseasSalesType");
				oprot.WriteByte((byte)structs.GetOverseasSalesType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSalesNo() != null) {
				
				oprot.WriteFieldBegin("salesNo");
				oprot.WriteI64((long)structs.GetSalesNo()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetChannel() != null) {
				
				oprot.WriteFieldBegin("channel");
				oprot.WriteString(structs.GetChannel());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetContractMode() != null) {
				
				oprot.WriteFieldBegin("contractMode");
				oprot.WriteByte((byte)structs.GetContractMode()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOxoContractNo() != null) {
				
				oprot.WriteFieldBegin("oxoContractNo");
				oprot.WriteString(structs.GetOxoContractNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOxoContractName() != null) {
				
				oprot.WriteFieldBegin("oxoContractName");
				oprot.WriteString(structs.GetOxoContractName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOxoContractTime() != null) {
				
				oprot.WriteFieldBegin("oxoContractTime");
				oprot.WriteI64((long)structs.GetOxoContractTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ProtContractMainInfoModel bean){
			
			
		}
		
	}
	
}