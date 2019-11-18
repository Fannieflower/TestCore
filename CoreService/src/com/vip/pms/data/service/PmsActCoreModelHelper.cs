using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class PmsActCoreModelHelper : TBeanSerializer<PmsActCoreModel>
	{
		
		public static PmsActCoreModelHelper OBJ = new PmsActCoreModelHelper();
		
		public static PmsActCoreModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PmsActCoreModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("actType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetActType(value);
					}
					
					
					
					
					
					if ("actName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetActName(value);
					}
					
					
					
					
					
					if ("actChannel".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetActChannel(value);
					}
					
					
					
					
					
					if ("status".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetStatus(value);
					}
					
					
					
					
					
					if ("actRange".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetActRange(value);
					}
					
					
					
					
					
					if ("beginTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetBeginTime(value);
					}
					
					
					
					
					
					if ("endTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetEndTime(value);
					}
					
					
					
					
					
					if ("actMsg".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetActMsg(value);
					}
					
					
					
					
					
					if ("priorityLevel".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetPriorityLevel(value);
					}
					
					
					
					
					
					if ("groupBuyingFlag".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.pms.data.enums.GroupBuyingFlag? value;
						
						value = com.vip.pms.data.enums.GroupBuyingFlagUtil.FindByName(iprot.ReadString());
						
						structs.SetGroupBuyingFlag(value);
					}
					
					
					
					
					
					if ("prepayFavType".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.pms.data.enums.PrepayFavType? value;
						
						value = com.vip.pms.data.enums.PrepayFavTypeUtil.FindByName(iprot.ReadString());
						
						structs.SetPrepayFavType(value);
					}
					
					
					
					
					
					if ("saleModes".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadSetBegin();
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
						
						iprot.ReadSetEnd();
						
						structs.SetSaleModes(value);
					}
					
					
					
					
					
					if ("supportPrepayFlag".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.pms.data.enums.SupportPrepayFlag? value;
						
						value = com.vip.pms.data.enums.SupportPrepayFlagUtil.FindByName(iprot.ReadString());
						
						structs.SetSupportPrepayFlag(value);
					}
					
					
					
					
					
					if ("actMainNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetActMainNo(value);
					}
					
					
					
					
					
					if ("categoryList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.CouponRangeModel> value;
						
						value = new List<com.vip.pms.data.service.CouponRangeModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.CouponRangeModel elem1;
								
								elem1 = new com.vip.pms.data.service.CouponRangeModel();
								com.vip.pms.data.service.CouponRangeModelHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetCategoryList(value);
					}
					
					
					
					
					
					if ("categoryChannelId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCategoryChannelId(value);
					}
					
					
					
					
					
					if ("shopIconMsg".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetShopIconMsg(value);
					}
					
					
					
					
					
					if ("cartIconMsg".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCartIconMsg(value);
					}
					
					
					
					
					
					if ("prestartTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPrestartTime(value);
					}
					
					
					
					
					
					if ("label".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetLabel(value);
					}
					
					
					
					
					
					if ("activityRangeSalesMode".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetActivityRangeSalesMode(value);
					}
					
					
					
					
					
					if ("channelList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<int?> value;
						
						value = new List<int?>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								int elem3;
								elem3 = iprot.ReadI32(); 
								
								value.Add(elem3);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetChannelList(value);
					}
					
					
					
					
					
					if ("prepayTailMoneyBeginTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetPrepayTailMoneyBeginTime(value);
					}
					
					
					
					
					
					if ("prepayTailMoneyEndTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetPrepayTailMoneyEndTime(value);
					}
					
					
					
					
					
					if ("usePromoPic".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetUsePromoPic(value);
					}
					
					
					
					
					
					if ("planId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetPlanId(value);
					}
					
					
					
					
					
					if ("isQuota".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetIsQuota(value);
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
		
		
		public void Write(PmsActCoreModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetActType() != null) {
				
				oprot.WriteFieldBegin("actType");
				oprot.WriteI32((int)structs.GetActType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("actType can not be null!");
			}
			
			
			if(structs.GetActName() != null) {
				
				oprot.WriteFieldBegin("actName");
				oprot.WriteString(structs.GetActName());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("actName can not be null!");
			}
			
			
			if(structs.GetActChannel() != null) {
				
				oprot.WriteFieldBegin("actChannel");
				oprot.WriteI32((int)structs.GetActChannel()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("actChannel can not be null!");
			}
			
			
			if(structs.GetStatus() != null) {
				
				oprot.WriteFieldBegin("status");
				oprot.WriteI32((int)structs.GetStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("status can not be null!");
			}
			
			
			if(structs.GetActRange() != null) {
				
				oprot.WriteFieldBegin("actRange");
				oprot.WriteI32((int)structs.GetActRange()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("actRange can not be null!");
			}
			
			
			if(structs.GetBeginTime() != null) {
				
				oprot.WriteFieldBegin("beginTime");
				oprot.WriteI64((long)structs.GetBeginTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("beginTime can not be null!");
			}
			
			
			if(structs.GetEndTime() != null) {
				
				oprot.WriteFieldBegin("endTime");
				oprot.WriteI64((long)structs.GetEndTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("endTime can not be null!");
			}
			
			
			if(structs.GetActMsg() != null) {
				
				oprot.WriteFieldBegin("actMsg");
				oprot.WriteString(structs.GetActMsg());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("actMsg can not be null!");
			}
			
			
			if(structs.GetPriorityLevel() != null) {
				
				oprot.WriteFieldBegin("priorityLevel");
				oprot.WriteI32((int)structs.GetPriorityLevel()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("priorityLevel can not be null!");
			}
			
			
			if(structs.GetGroupBuyingFlag() != null) {
				
				oprot.WriteFieldBegin("groupBuyingFlag");
				oprot.WriteString(structs.GetGroupBuyingFlag().ToString());  
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("groupBuyingFlag can not be null!");
			}
			
			
			if(structs.GetPrepayFavType() != null) {
				
				oprot.WriteFieldBegin("prepayFavType");
				oprot.WriteString(structs.GetPrepayFavType().ToString());  
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSaleModes() != null) {
				
				oprot.WriteFieldBegin("saleModes");
				
				oprot.WriteSetBegin();
				foreach(string _item0 in structs.GetSaleModes()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteSetEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSupportPrepayFlag() != null) {
				
				oprot.WriteFieldBegin("supportPrepayFlag");
				oprot.WriteString(structs.GetSupportPrepayFlag().ToString());  
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("supportPrepayFlag can not be null!");
			}
			
			
			if(structs.GetActMainNo() != null) {
				
				oprot.WriteFieldBegin("actMainNo");
				oprot.WriteI64((long)structs.GetActMainNo()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCategoryList() != null) {
				
				oprot.WriteFieldBegin("categoryList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.CouponRangeModel _item0 in structs.GetCategoryList()){
					
					
					com.vip.pms.data.service.CouponRangeModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCategoryChannelId() != null) {
				
				oprot.WriteFieldBegin("categoryChannelId");
				oprot.WriteString(structs.GetCategoryChannelId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetShopIconMsg() != null) {
				
				oprot.WriteFieldBegin("shopIconMsg");
				oprot.WriteString(structs.GetShopIconMsg());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCartIconMsg() != null) {
				
				oprot.WriteFieldBegin("cartIconMsg");
				oprot.WriteString(structs.GetCartIconMsg());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPrestartTime() != null) {
				
				oprot.WriteFieldBegin("prestartTime");
				oprot.WriteI32((int)structs.GetPrestartTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLabel() != null) {
				
				oprot.WriteFieldBegin("label");
				oprot.WriteI32((int)structs.GetLabel()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetActivityRangeSalesMode() != null) {
				
				oprot.WriteFieldBegin("activityRangeSalesMode");
				oprot.WriteI32((int)structs.GetActivityRangeSalesMode()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetChannelList() != null) {
				
				oprot.WriteFieldBegin("channelList");
				
				oprot.WriteListBegin();
				foreach(int _item0 in structs.GetChannelList()){
					
					oprot.WriteI32((int)_item0); 
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPrepayTailMoneyBeginTime() != null) {
				
				oprot.WriteFieldBegin("prepayTailMoneyBeginTime");
				oprot.WriteI64((long)structs.GetPrepayTailMoneyBeginTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPrepayTailMoneyEndTime() != null) {
				
				oprot.WriteFieldBegin("prepayTailMoneyEndTime");
				oprot.WriteI64((long)structs.GetPrepayTailMoneyEndTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUsePromoPic() != null) {
				
				oprot.WriteFieldBegin("usePromoPic");
				oprot.WriteByte((byte)structs.GetUsePromoPic()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPlanId() != null) {
				
				oprot.WriteFieldBegin("planId");
				oprot.WriteI64((long)structs.GetPlanId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsQuota() != null) {
				
				oprot.WriteFieldBegin("isQuota");
				oprot.WriteByte((byte)structs.GetIsQuota()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PmsActCoreModel bean){
			
			
		}
		
	}
	
}