using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vis.purchase.schedules.service.query{
	
	
	
	public class ScheduleInfoDataHelper : TBeanSerializer<ScheduleInfoData>
	{
		
		public static ScheduleInfoDataHelper OBJ = new ScheduleInfoDataHelper();
		
		public static ScheduleInfoDataHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ScheduleInfoData structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("sellingMode".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetSellingMode(value);
					}
					
					
					
					
					
					if ("sellingAction".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSellingAction(value);
					}
					
					
					
					
					
					if ("b2cModeId".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetB2cModeId(value);
					}
					
					
					
					
					
					if ("sellTimeFrom".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetSellTimeFrom(value);
					}
					
					
					
					
					
					if ("sellTimeTo".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetSellTimeTo(value);
					}
					
					
					
					
					
					if ("specialOperationsFlag".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetSpecialOperationsFlag(value);
					}
					
					
					
					
					
					if ("exclusiveOrShare".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetExclusiveOrShare(value);
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
					
					
					
					
					
					if ("createTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetCreateTime(value);
					}
					
					
					
					
					
					if ("updateTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetUpdateTime(value);
					}
					
					
					
					
					
					if ("createBy".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCreateBy(value);
					}
					
					
					
					
					
					if ("normalityFlag".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetNormalityFlag(value);
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
		
		
		public void Write(ScheduleInfoData structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetBrandId() != null) {
				
				oprot.WriteFieldBegin("brandId");
				oprot.WriteI64((long)structs.GetBrandId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSellingMode() != null) {
				
				oprot.WriteFieldBegin("sellingMode");
				oprot.WriteByte((byte)structs.GetSellingMode()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSellingAction() != null) {
				
				oprot.WriteFieldBegin("sellingAction");
				oprot.WriteString(structs.GetSellingAction());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetB2cModeId() != null) {
				
				oprot.WriteFieldBegin("b2cModeId");
				oprot.WriteI32((int)structs.GetB2cModeId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSellTimeFrom() != null) {
				
				oprot.WriteFieldBegin("sellTimeFrom");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetSellTimeFrom())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSellTimeTo() != null) {
				
				oprot.WriteFieldBegin("sellTimeTo");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetSellTimeTo())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSpecialOperationsFlag() != null) {
				
				oprot.WriteFieldBegin("specialOperationsFlag");
				oprot.WriteByte((byte)structs.GetSpecialOperationsFlag()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExclusiveOrShare() != null) {
				
				oprot.WriteFieldBegin("exclusiveOrShare");
				oprot.WriteByte((byte)structs.GetExclusiveOrShare()); 
				
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
			
			
			if(structs.GetCreateTime() != null) {
				
				oprot.WriteFieldBegin("createTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetCreateTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUpdateTime() != null) {
				
				oprot.WriteFieldBegin("updateTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetUpdateTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreateBy() != null) {
				
				oprot.WriteFieldBegin("createBy");
				oprot.WriteString(structs.GetCreateBy());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetNormalityFlag() != null) {
				
				oprot.WriteFieldBegin("normalityFlag");
				oprot.WriteByte((byte)structs.GetNormalityFlag()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ScheduleInfoData bean){
			
			
		}
		
	}
	
}