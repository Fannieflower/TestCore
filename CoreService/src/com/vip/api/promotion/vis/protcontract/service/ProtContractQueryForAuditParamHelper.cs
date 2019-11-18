using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	public class ProtContractQueryForAuditParamHelper : TBeanSerializer<ProtContractQueryForAuditParam>
	{
		
		public static ProtContractQueryForAuditParamHelper OBJ = new ProtContractQueryForAuditParamHelper();
		
		public static ProtContractQueryForAuditParamHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ProtContractQueryForAuditParam structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("protNos".Equals(schemeField.Trim())){
						
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
						
						structs.SetProtNos(value);
					}
					
					
					
					
					
					if ("activityAlltype".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetActivityAlltype(value);
					}
					
					
					
					
					
					if ("signMode".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetSignMode(value);
					}
					
					
					
					
					
					if ("onlineStarttimeStart".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetOnlineStarttimeStart(value);
					}
					
					
					
					
					
					if ("onlineStarttimeEnd".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetOnlineStarttimeEnd(value);
					}
					
					
					
					
					
					if ("onlineEndtimeStart".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetOnlineEndtimeStart(value);
					}
					
					
					
					
					
					if ("onlineEndtimeEnd".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetOnlineEndtimeEnd(value);
					}
					
					
					
					
					
					if ("vendorCodes".Equals(schemeField.Trim())){
						
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
						
						structs.SetVendorCodes(value);
					}
					
					
					
					
					
					if ("vendorName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVendorName(value);
					}
					
					
					
					
					
					if ("rangeType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetRangeType(value);
					}
					
					
					
					
					
					if ("stage".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetStage(value);
					}
					
					
					
					
					
					if ("auditStatus".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetAuditStatus(value);
					}
					
					
					
					
					
					if ("dataRange".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetDataRange(value);
					}
					
					
					
					
					
					if ("dataAreaIds".Equals(schemeField.Trim())){
						
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
						
						structs.SetDataAreaIds(value);
					}
					
					
					
					
					
					if ("userEmail".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUserEmail(value);
					}
					
					
					
					
					
					if ("userId".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetUserId(value);
					}
					
					
					
					
					
					if ("brandSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandSn(value);
					}
					
					
					
					
					
					if ("matchScheduleCreator".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool? value;
						value = iprot.ReadBool();
						
						structs.SetMatchScheduleCreator(value);
					}
					
					
					
					
					
					if ("orderBy".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetOrderBy(value);
					}
					
					
					
					
					
					if ("specialName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSpecialName(value);
					}
					
					
					
					
					
					if ("bearType".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<byte?> value;
						
						value = new List<byte?>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								byte elem3;
								elem3 = iprot.ReadByte(); 
								
								value.Add(elem3);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetBearType(value);
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
					
					
					
					
					
					if ("contractMode".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetContractMode(value);
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
		
		
		public void Write(ProtContractQueryForAuditParam structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetProtNos() != null) {
				
				oprot.WriteFieldBegin("protNos");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetProtNos()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetActivityAlltype() != null) {
				
				oprot.WriteFieldBegin("activityAlltype");
				oprot.WriteString(structs.GetActivityAlltype());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSignMode() != null) {
				
				oprot.WriteFieldBegin("signMode");
				oprot.WriteByte((byte)structs.GetSignMode()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOnlineStarttimeStart() != null) {
				
				oprot.WriteFieldBegin("onlineStarttimeStart");
				oprot.WriteI64((long)structs.GetOnlineStarttimeStart()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOnlineStarttimeEnd() != null) {
				
				oprot.WriteFieldBegin("onlineStarttimeEnd");
				oprot.WriteI64((long)structs.GetOnlineStarttimeEnd()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOnlineEndtimeStart() != null) {
				
				oprot.WriteFieldBegin("onlineEndtimeStart");
				oprot.WriteI64((long)structs.GetOnlineEndtimeStart()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOnlineEndtimeEnd() != null) {
				
				oprot.WriteFieldBegin("onlineEndtimeEnd");
				oprot.WriteI64((long)structs.GetOnlineEndtimeEnd()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendorCodes() != null) {
				
				oprot.WriteFieldBegin("vendorCodes");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetVendorCodes()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendorName() != null) {
				
				oprot.WriteFieldBegin("vendorName");
				oprot.WriteString(structs.GetVendorName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRangeType() != null) {
				
				oprot.WriteFieldBegin("rangeType");
				oprot.WriteByte((byte)structs.GetRangeType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStage() != null) {
				
				oprot.WriteFieldBegin("stage");
				oprot.WriteByte((byte)structs.GetStage()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAuditStatus() != null) {
				
				oprot.WriteFieldBegin("auditStatus");
				oprot.WriteByte((byte)structs.GetAuditStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDataRange() != null) {
				
				oprot.WriteFieldBegin("dataRange");
				oprot.WriteByte((byte)structs.GetDataRange()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDataAreaIds() != null) {
				
				oprot.WriteFieldBegin("dataAreaIds");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetDataAreaIds()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUserEmail() != null) {
				
				oprot.WriteFieldBegin("userEmail");
				oprot.WriteString(structs.GetUserEmail());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUserId() != null) {
				
				oprot.WriteFieldBegin("userId");
				oprot.WriteI32((int)structs.GetUserId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandSn() != null) {
				
				oprot.WriteFieldBegin("brandSn");
				oprot.WriteString(structs.GetBrandSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMatchScheduleCreator() != null) {
				
				oprot.WriteFieldBegin("matchScheduleCreator");
				oprot.WriteBool((bool)structs.GetMatchScheduleCreator());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderBy() != null) {
				
				oprot.WriteFieldBegin("orderBy");
				oprot.WriteByte((byte)structs.GetOrderBy()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSpecialName() != null) {
				
				oprot.WriteFieldBegin("specialName");
				oprot.WriteString(structs.GetSpecialName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBearType() != null) {
				
				oprot.WriteFieldBegin("bearType");
				
				oprot.WriteListBegin();
				foreach(byte _item0 in structs.GetBearType()){
					
					oprot.WriteByte((byte)_item0); 
					
				}
				
				oprot.WriteListEnd();
				
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
			
			
			if(structs.GetContractMode() != null) {
				
				oprot.WriteFieldBegin("contractMode");
				oprot.WriteByte((byte)structs.GetContractMode()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ProtContractQueryForAuditParam bean){
			
			
		}
		
	}
	
}