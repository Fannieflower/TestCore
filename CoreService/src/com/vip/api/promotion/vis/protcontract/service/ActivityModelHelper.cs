using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	public class ActivityModelHelper : TBeanSerializer<ActivityModel>
	{
		
		public static ActivityModelHelper OBJ = new ActivityModelHelper();
		
		public static ActivityModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ActivityModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("onlineStarttime".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOnlineStarttime(value);
					}
					
					
					
					
					
					if ("onlineEndtime".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOnlineEndtime(value);
					}
					
					
					
					
					
					if ("commodityList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.api.promotion.vis.protcontract.service.CommodityModel> value;
						
						value = new List<com.vip.api.promotion.vis.protcontract.service.CommodityModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.api.promotion.vis.protcontract.service.CommodityModel elem0;
								
								elem0 = new com.vip.api.promotion.vis.protcontract.service.CommodityModel();
								com.vip.api.promotion.vis.protcontract.service.CommodityModelHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetCommodityList(value);
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
		
		
		public void Write(ActivityModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetOnlineStarttime() != null) {
				
				oprot.WriteFieldBegin("onlineStarttime");
				oprot.WriteString(structs.GetOnlineStarttime());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOnlineEndtime() != null) {
				
				oprot.WriteFieldBegin("onlineEndtime");
				oprot.WriteString(structs.GetOnlineEndtime());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCommodityList() != null) {
				
				oprot.WriteFieldBegin("commodityList");
				
				oprot.WriteListBegin();
				foreach(com.vip.api.promotion.vis.protcontract.service.CommodityModel _item0 in structs.GetCommodityList()){
					
					
					com.vip.api.promotion.vis.protcontract.service.CommodityModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ActivityModel bean){
			
			
		}
		
	}
	
}