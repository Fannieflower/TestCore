using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	public class ProtContractQueryParamHelper : TBeanSerializer<ProtContractQueryParam>
	{
		
		public static ProtContractQueryParamHelper OBJ = new ProtContractQueryParamHelper();
		
		public static ProtContractQueryParamHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ProtContractQueryParam structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("status".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetStatus(value);
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
					
					
					
					
					
					if ("orderBy".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetOrderBy(value);
					}
					
					
					
					
					
					if ("brandSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandSn(value);
					}
					
					
					
					
					
					if ("brandId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandId(value);
					}
					
					
					
					
					
					if ("specialName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSpecialName(value);
					}
					
					
					
					
					
					if ("basicStatus".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetBasicStatus(value);
					}
					
					
					
					
					
					if ("beginTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetBeginTime(value);
					}
					
					
					
					
					
					if ("endTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetEndTime(value);
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
					
					
					
					
					
					if ("contractMode".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetContractMode(value);
					}
					
					
					
					
					
					if ("contractIds".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<long?> value;
						
						value = new List<long?>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								long elem3;
								elem3 = iprot.ReadI64(); 
								
								value.Add(elem3);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetContractIds(value);
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
		
		
		public void Write(ProtContractQueryParam structs, Protocol oprot){
			
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
			
			
			if(structs.GetStatus() != null) {
				
				oprot.WriteFieldBegin("status");
				oprot.WriteByte((byte)structs.GetStatus()); 
				
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
			
			
			if(structs.GetDataAreaIds() != null) {
				
				oprot.WriteFieldBegin("dataAreaIds");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetDataAreaIds()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderBy() != null) {
				
				oprot.WriteFieldBegin("orderBy");
				oprot.WriteByte((byte)structs.GetOrderBy()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandSn() != null) {
				
				oprot.WriteFieldBegin("brandSn");
				oprot.WriteString(structs.GetBrandSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandId() != null) {
				
				oprot.WriteFieldBegin("brandId");
				oprot.WriteString(structs.GetBrandId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSpecialName() != null) {
				
				oprot.WriteFieldBegin("specialName");
				oprot.WriteString(structs.GetSpecialName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBasicStatus() != null) {
				
				oprot.WriteFieldBegin("basicStatus");
				oprot.WriteByte((byte)structs.GetBasicStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBeginTime() != null) {
				
				oprot.WriteFieldBegin("beginTime");
				oprot.WriteI64((long)structs.GetBeginTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetEndTime() != null) {
				
				oprot.WriteFieldBegin("endTime");
				oprot.WriteI64((long)structs.GetEndTime()); 
				
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
			
			
			if(structs.GetContractMode() != null) {
				
				oprot.WriteFieldBegin("contractMode");
				oprot.WriteByte((byte)structs.GetContractMode()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetContractIds() != null) {
				
				oprot.WriteFieldBegin("contractIds");
				
				oprot.WriteListBegin();
				foreach(long _item0 in structs.GetContractIds()){
					
					oprot.WriteI64((long)_item0); 
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ProtContractQueryParam bean){
			
			
		}
		
	}
	
}