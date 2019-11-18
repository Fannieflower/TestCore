using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class PmsPayCoreModelHelper : TBeanSerializer<PmsPayCoreModel>
	{
		
		public static PmsPayCoreModelHelper OBJ = new PmsPayCoreModelHelper();
		
		public static PmsPayCoreModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PmsPayCoreModel structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("firstOrder".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetFirstOrder(value);
					}
					
					
					
					
					
					if ("isAllowRepeat".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetIsAllowRepeat(value);
					}
					
					
					
					
					
					if ("participateNum".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetParticipateNum(value);
					}
					
					
					
					
					
					if ("peopleNumLimit".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetPeopleNumLimit(value);
					}
					
					
					
					
					
					if ("showAd".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetShowAd(value);
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
					
					
					
					
					
					if ("customerSrcList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.PmsActConfigModel> value;
						
						value = new List<com.vip.pms.data.service.PmsActConfigModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.PmsActConfigModel elem0;
								
								elem0 = new com.vip.pms.data.service.PmsActConfigModel();
								com.vip.pms.data.service.PmsActConfigModelHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetCustomerSrcList(value);
					}
					
					
					
					
					
					if ("customerTagList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.PmsActConfigModel> value;
						
						value = new List<com.vip.pms.data.service.PmsActConfigModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.PmsActConfigModel elem2;
								
								elem2 = new com.vip.pms.data.service.PmsActConfigModel();
								com.vip.pms.data.service.PmsActConfigModelHelper.getInstance().Read(elem2, iprot);
								
								value.Add(elem2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetCustomerTagList(value);
					}
					
					
					
					
					
					if ("payHouseList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.PmsPayHouseModel> value;
						
						value = new List<com.vip.pms.data.service.PmsPayHouseModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.PmsPayHouseModel elem4;
								
								elem4 = new com.vip.pms.data.service.PmsPayHouseModel();
								com.vip.pms.data.service.PmsPayHouseModelHelper.getInstance().Read(elem4, iprot);
								
								value.Add(elem4);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetPayHouseList(value);
					}
					
					
					
					
					
					if ("payDetailList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.PmsActConfigModel> value;
						
						value = new List<com.vip.pms.data.service.PmsActConfigModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.PmsActConfigModel elem6;
								
								elem6 = new com.vip.pms.data.service.PmsActConfigModel();
								com.vip.pms.data.service.PmsActConfigModelHelper.getInstance().Read(elem6, iprot);
								
								value.Add(elem6);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetPayDetailList(value);
					}
					
					
					
					
					
					if ("actMsg".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetActMsg(value);
					}
					
					
					
					
					
					if ("isBlackFilter".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsBlackFilter(value);
					}
					
					
					
					
					
					if ("blackFilterMsg".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBlackFilterMsg(value);
					}
					
					
					
					
					
					if ("isCategoryBlackFilter".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsCategoryBlackFilter(value);
					}
					
					
					
					
					
					if ("audienceConfigList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.PmsActAudienceConfigModel> value;
						
						value = new List<com.vip.pms.data.service.PmsActAudienceConfigModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.PmsActAudienceConfigModel elem8;
								
								elem8 = new com.vip.pms.data.service.PmsActAudienceConfigModel();
								com.vip.pms.data.service.PmsActAudienceConfigModelHelper.getInstance().Read(elem8, iprot);
								
								value.Add(elem8);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetAudienceConfigList(value);
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
		
		
		public void Write(PmsPayCoreModel structs, Protocol oprot){
			
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
			
			
			if(structs.GetFirstOrder() != null) {
				
				oprot.WriteFieldBegin("firstOrder");
				oprot.WriteI32((int)structs.GetFirstOrder()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("firstOrder can not be null!");
			}
			
			
			if(structs.GetIsAllowRepeat() != null) {
				
				oprot.WriteFieldBegin("isAllowRepeat");
				oprot.WriteI32((int)structs.GetIsAllowRepeat()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("isAllowRepeat can not be null!");
			}
			
			
			if(structs.GetParticipateNum() != null) {
				
				oprot.WriteFieldBegin("participateNum");
				oprot.WriteI32((int)structs.GetParticipateNum()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("participateNum can not be null!");
			}
			
			
			if(structs.GetPeopleNumLimit() != null) {
				
				oprot.WriteFieldBegin("peopleNumLimit");
				oprot.WriteI32((int)structs.GetPeopleNumLimit()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("peopleNumLimit can not be null!");
			}
			
			
			if(structs.GetShowAd() != null) {
				
				oprot.WriteFieldBegin("showAd");
				oprot.WriteI32((int)structs.GetShowAd()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("showAd can not be null!");
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
			
			
			if(structs.GetCustomerSrcList() != null) {
				
				oprot.WriteFieldBegin("customerSrcList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.PmsActConfigModel _item0 in structs.GetCustomerSrcList()){
					
					
					com.vip.pms.data.service.PmsActConfigModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustomerTagList() != null) {
				
				oprot.WriteFieldBegin("customerTagList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.PmsActConfigModel _item0 in structs.GetCustomerTagList()){
					
					
					com.vip.pms.data.service.PmsActConfigModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPayHouseList() != null) {
				
				oprot.WriteFieldBegin("payHouseList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.PmsPayHouseModel _item0 in structs.GetPayHouseList()){
					
					
					com.vip.pms.data.service.PmsPayHouseModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("payHouseList can not be null!");
			}
			
			
			if(structs.GetPayDetailList() != null) {
				
				oprot.WriteFieldBegin("payDetailList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.PmsActConfigModel _item0 in structs.GetPayDetailList()){
					
					
					com.vip.pms.data.service.PmsActConfigModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("payDetailList can not be null!");
			}
			
			
			if(structs.GetActMsg() != null) {
				
				oprot.WriteFieldBegin("actMsg");
				oprot.WriteString(structs.GetActMsg());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("actMsg can not be null!");
			}
			
			
			if(structs.GetIsBlackFilter() != null) {
				
				oprot.WriteFieldBegin("isBlackFilter");
				oprot.WriteI32((int)structs.GetIsBlackFilter()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBlackFilterMsg() != null) {
				
				oprot.WriteFieldBegin("blackFilterMsg");
				oprot.WriteString(structs.GetBlackFilterMsg());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsCategoryBlackFilter() != null) {
				
				oprot.WriteFieldBegin("isCategoryBlackFilter");
				oprot.WriteI32((int)structs.GetIsCategoryBlackFilter()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAudienceConfigList() != null) {
				
				oprot.WriteFieldBegin("audienceConfigList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.PmsActAudienceConfigModel _item0 in structs.GetAudienceConfigList()){
					
					
					com.vip.pms.data.service.PmsActAudienceConfigModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PmsPayCoreModel bean){
			
			
		}
		
	}
	
}