using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	public class ProtContractMainInfoParamsHelper : TBeanSerializer<ProtContractMainInfoParams>
	{
		
		public static ProtContractMainInfoParamsHelper OBJ = new ProtContractMainInfoParamsHelper();
		
		public static ProtContractMainInfoParamsHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ProtContractMainInfoParams structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("brandId".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetBrandId(value);
					}
					
					
					
					
					
					if ("businessType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte value;
						value = iprot.ReadByte(); 
						
						structs.SetBusinessType(value);
					}
					
					
					
					
					
					if ("contractDimension".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte value;
						value = iprot.ReadByte(); 
						
						structs.SetContractDimension(value);
					}
					
					
					
					
					
					if ("companyName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCompanyName(value);
					}
					
					
					
					
					
					if ("salesWarehouseList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.api.promotion.vis.protcontract.service.SalesWarehouse> value;
						
						value = new List<com.vip.api.promotion.vis.protcontract.service.SalesWarehouse>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.api.promotion.vis.protcontract.service.SalesWarehouse elem0;
								
								elem0 = new com.vip.api.promotion.vis.protcontract.service.SalesWarehouse();
								com.vip.api.promotion.vis.protcontract.service.SalesWarehouseHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetSalesWarehouseList(value);
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
		
		
		public void Write(ProtContractMainInfoParams structs, Protocol oprot){
			
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
			
			
			if(structs.GetBrandId() != null) {
				
				oprot.WriteFieldBegin("brandId");
				oprot.WriteI32((int)structs.GetBrandId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBusinessType() != null) {
				
				oprot.WriteFieldBegin("businessType");
				oprot.WriteByte((byte)structs.GetBusinessType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("businessType can not be null!");
			}
			
			
			if(structs.GetContractDimension() != null) {
				
				oprot.WriteFieldBegin("contractDimension");
				oprot.WriteByte((byte)structs.GetContractDimension()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("contractDimension can not be null!");
			}
			
			
			if(structs.GetCompanyName() != null) {
				
				oprot.WriteFieldBegin("companyName");
				oprot.WriteString(structs.GetCompanyName());
				
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
		
		
		public void Validate(ProtContractMainInfoParams bean){
			
			
		}
		
	}
	
}