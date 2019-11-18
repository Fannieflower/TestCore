using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vis.purchase.schedules.service.query{
	
	
	
	public class ScheduleByShopCodeHelper : TBeanSerializer<ScheduleByShopCode>
	{
		
		public static ScheduleByShopCodeHelper OBJ = new ScheduleByShopCodeHelper();
		
		public static ScheduleByShopCodeHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ScheduleByShopCode structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
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
					
					
					
					
					
					if ("shopCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetShopCode(value);
					}
					
					
					
					
					
					if ("shopName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetShopName(value);
					}
					
					
					
					
					
					if ("sellingAction".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSellingAction(value);
					}
					
					
					
					
					
					if ("schedulesList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vis.purchase.schedules.service.query.ApplySchedules> value;
						
						value = new List<com.vip.vis.purchase.schedules.service.query.ApplySchedules>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vis.purchase.schedules.service.query.ApplySchedules elem0;
								
								elem0 = new com.vip.vis.purchase.schedules.service.query.ApplySchedules();
								com.vip.vis.purchase.schedules.service.query.ApplySchedulesHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetSchedulesList(value);
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
					
					
					
					
					
					if ("createTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetCreateTime(value);
					}
					
					
					
					
					
					if ("sellingMode".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetSellingMode(value);
					}
					
					
					
					
					
					if ("sellingModeReadable".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSellingModeReadable(value);
					}
					
					
					
					
					
					if ("b2cModeId".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetB2cModeId(value);
					}
					
					
					
					
					
					if ("cooperationType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetCooperationType(value);
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
					
					
					
					
					
					if ("brandList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vis.purchase.schedules.service.query.ApplyBrand> value;
						
						value = new List<com.vip.vis.purchase.schedules.service.query.ApplyBrand>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vis.purchase.schedules.service.query.ApplyBrand elem2;
								
								elem2 = new com.vip.vis.purchase.schedules.service.query.ApplyBrand();
								com.vip.vis.purchase.schedules.service.query.ApplyBrandHelper.getInstance().Read(elem2, iprot);
								
								value.Add(elem2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetBrandList(value);
					}
					
					
					
					
					
					if ("createBy".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCreateBy(value);
					}
					
					
					
					
					
					if ("contractCurrency".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetContractCurrency(value);
					}
					
					
					
					
					
					if ("isHt".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetIsHt(value);
					}
					
					
					
					
					
					if ("isStoreSale".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetIsStoreSale(value);
					}
					
					
					
					
					
					if ("specialOperationsFlag".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetSpecialOperationsFlag(value);
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
		
		
		public void Write(ScheduleByShopCode structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
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
			
			
			if(structs.GetShopCode() != null) {
				
				oprot.WriteFieldBegin("shopCode");
				oprot.WriteI64((long)structs.GetShopCode()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetShopName() != null) {
				
				oprot.WriteFieldBegin("shopName");
				oprot.WriteString(structs.GetShopName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSellingAction() != null) {
				
				oprot.WriteFieldBegin("sellingAction");
				oprot.WriteString(structs.GetSellingAction());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSchedulesList() != null) {
				
				oprot.WriteFieldBegin("schedulesList");
				
				oprot.WriteListBegin();
				foreach(com.vip.vis.purchase.schedules.service.query.ApplySchedules _item0 in structs.GetSchedulesList()){
					
					
					com.vip.vis.purchase.schedules.service.query.ApplySchedulesHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
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
			
			
			if(structs.GetCreateTime() != null) {
				
				oprot.WriteFieldBegin("createTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetCreateTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSellingMode() != null) {
				
				oprot.WriteFieldBegin("sellingMode");
				oprot.WriteByte((byte)structs.GetSellingMode()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSellingModeReadable() != null) {
				
				oprot.WriteFieldBegin("sellingModeReadable");
				oprot.WriteString(structs.GetSellingModeReadable());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetB2cModeId() != null) {
				
				oprot.WriteFieldBegin("b2cModeId");
				oprot.WriteI32((int)structs.GetB2cModeId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCooperationType() != null) {
				
				oprot.WriteFieldBegin("cooperationType");
				oprot.WriteByte((byte)structs.GetCooperationType()); 
				
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
			
			
			if(structs.GetBrandList() != null) {
				
				oprot.WriteFieldBegin("brandList");
				
				oprot.WriteListBegin();
				foreach(com.vip.vis.purchase.schedules.service.query.ApplyBrand _item0 in structs.GetBrandList()){
					
					
					com.vip.vis.purchase.schedules.service.query.ApplyBrandHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreateBy() != null) {
				
				oprot.WriteFieldBegin("createBy");
				oprot.WriteString(structs.GetCreateBy());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetContractCurrency() != null) {
				
				oprot.WriteFieldBegin("contractCurrency");
				oprot.WriteString(structs.GetContractCurrency());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsHt() != null) {
				
				oprot.WriteFieldBegin("isHt");
				oprot.WriteByte((byte)structs.GetIsHt()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsStoreSale() != null) {
				
				oprot.WriteFieldBegin("isStoreSale");
				oprot.WriteByte((byte)structs.GetIsStoreSale()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSpecialOperationsFlag() != null) {
				
				oprot.WriteFieldBegin("specialOperationsFlag");
				oprot.WriteByte((byte)structs.GetSpecialOperationsFlag()); 
				
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
			
			
			if(structs.GetGrossProfitRateLadderList() != null) {
				
				oprot.WriteFieldBegin("grossProfitRateLadderList");
				
				oprot.WriteListBegin();
				foreach(com.vip.vis.purchase.schedules.service.query.GrossProfitRateLadder _item0 in structs.GetGrossProfitRateLadderList()){
					
					
					com.vip.vis.purchase.schedules.service.query.GrossProfitRateLadderHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ScheduleByShopCode bean){
			
			
		}
		
	}
	
}