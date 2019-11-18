using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class PmsActConditionModelHelper : TBeanSerializer<PmsActConditionModel>
	{
		
		public static PmsActConditionModelHelper OBJ = new PmsActConditionModelHelper();
		
		public static PmsActConditionModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PmsActConditionModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("display".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetDisplay(value);
					}
					
					
					
					
					
					if ("peopleNumLimit".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetPeopleNumLimit(value);
					}
					
					
					
					
					
					if ("giveType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetGiveType(value);
					}
					
					
					
					
					
					if ("giftType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetGiftType(value);
					}
					
					
					
					
					
					if ("actGiftType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetActGiftType(value);
					}
					
					
					
					
					
					if ("isAllowRepeat".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetIsAllowRepeat(value);
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
					
					
					
					
					
					if ("customerLevelList".Equals(schemeField.Trim())){
						
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
						
						structs.SetCustomerLevelList(value);
					}
					
					
					
					
					
					if ("enterpriseType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetEnterpriseType(value);
					}
					
					
					
					
					
					if ("prepayFavType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPrepayFavType(value);
					}
					
					
					
					
					
					if ("mcKinseyList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.PmsActConfigModel> value;
						
						value = new List<com.vip.pms.data.service.PmsActConfigModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.PmsActConfigModel elem4;
								
								elem4 = new com.vip.pms.data.service.PmsActConfigModel();
								com.vip.pms.data.service.PmsActConfigModelHelper.getInstance().Read(elem4, iprot);
								
								value.Add(elem4);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetMcKinseyList(value);
					}
					
					
					
					
					
					if ("mcKinsey2List".Equals(schemeField.Trim())){
						
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
						
						structs.SetMcKinsey2List(value);
					}
					
					
					
					
					
					if ("customerTagList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.PmsActConfigModel> value;
						
						value = new List<com.vip.pms.data.service.PmsActConfigModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.PmsActConfigModel elem8;
								
								elem8 = new com.vip.pms.data.service.PmsActConfigModel();
								com.vip.pms.data.service.PmsActConfigModelHelper.getInstance().Read(elem8, iprot);
								
								value.Add(elem8);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetCustomerTagList(value);
					}
					
					
					
					
					
					if ("enterpriseList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.PmsActConfigModel> value;
						
						value = new List<com.vip.pms.data.service.PmsActConfigModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.PmsActConfigModel elem10;
								
								elem10 = new com.vip.pms.data.service.PmsActConfigModel();
								com.vip.pms.data.service.PmsActConfigModelHelper.getInstance().Read(elem10, iprot);
								
								value.Add(elem10);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetEnterpriseList(value);
					}
					
					
					
					
					
					if ("mobileChannelList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.PmsActConfigModel> value;
						
						value = new List<com.vip.pms.data.service.PmsActConfigModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.PmsActConfigModel elem12;
								
								elem12 = new com.vip.pms.data.service.PmsActConfigModel();
								com.vip.pms.data.service.PmsActConfigModelHelper.getInstance().Read(elem12, iprot);
								
								value.Add(elem12);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetMobileChannelList(value);
					}
					
					
					
					
					
					if ("repeatAmountLimit".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetRepeatAmountLimit(value);
					}
					
					
					
					
					
					if ("freeCarriageList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.PmsActConfigModel> value;
						
						value = new List<com.vip.pms.data.service.PmsActConfigModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.PmsActConfigModel elem14;
								
								elem14 = new com.vip.pms.data.service.PmsActConfigModel();
								com.vip.pms.data.service.PmsActConfigModelHelper.getInstance().Read(elem14, iprot);
								
								value.Add(elem14);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetFreeCarriageList(value);
					}
					
					
					
					
					
					if ("audienceConfigList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.PmsActAudienceConfigModel> value;
						
						value = new List<com.vip.pms.data.service.PmsActAudienceConfigModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.PmsActAudienceConfigModel elem16;
								
								elem16 = new com.vip.pms.data.service.PmsActAudienceConfigModel();
								com.vip.pms.data.service.PmsActAudienceConfigModelHelper.getInstance().Read(elem16, iprot);
								
								value.Add(elem16);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetAudienceConfigList(value);
					}
					
					
					
					
					
					if ("buyLimit".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetBuyLimit(value);
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
		
		
		public void Write(PmsActConditionModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetDisplay() != null) {
				
				oprot.WriteFieldBegin("display");
				oprot.WriteI32((int)structs.GetDisplay()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("display can not be null!");
			}
			
			
			if(structs.GetPeopleNumLimit() != null) {
				
				oprot.WriteFieldBegin("peopleNumLimit");
				oprot.WriteI32((int)structs.GetPeopleNumLimit()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("peopleNumLimit can not be null!");
			}
			
			
			if(structs.GetGiveType() != null) {
				
				oprot.WriteFieldBegin("giveType");
				oprot.WriteI32((int)structs.GetGiveType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("giveType can not be null!");
			}
			
			
			if(structs.GetGiftType() != null) {
				
				oprot.WriteFieldBegin("giftType");
				oprot.WriteI32((int)structs.GetGiftType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("giftType can not be null!");
			}
			
			
			if(structs.GetActGiftType() != null) {
				
				oprot.WriteFieldBegin("actGiftType");
				oprot.WriteI32((int)structs.GetActGiftType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("actGiftType can not be null!");
			}
			
			
			if(structs.GetIsAllowRepeat() != null) {
				
				oprot.WriteFieldBegin("isAllowRepeat");
				oprot.WriteI32((int)structs.GetIsAllowRepeat()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("isAllowRepeat can not be null!");
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
			
			
			if(structs.GetCustomerLevelList() != null) {
				
				oprot.WriteFieldBegin("customerLevelList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.PmsActConfigModel _item0 in structs.GetCustomerLevelList()){
					
					
					com.vip.pms.data.service.PmsActConfigModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetEnterpriseType() != null) {
				
				oprot.WriteFieldBegin("enterpriseType");
				oprot.WriteI32((int)structs.GetEnterpriseType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("enterpriseType can not be null!");
			}
			
			
			if(structs.GetPrepayFavType() != null) {
				
				oprot.WriteFieldBegin("prepayFavType");
				oprot.WriteString(structs.GetPrepayFavType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMcKinseyList() != null) {
				
				oprot.WriteFieldBegin("mcKinseyList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.PmsActConfigModel _item0 in structs.GetMcKinseyList()){
					
					
					com.vip.pms.data.service.PmsActConfigModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMcKinsey2List() != null) {
				
				oprot.WriteFieldBegin("mcKinsey2List");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.PmsActConfigModel _item0 in structs.GetMcKinsey2List()){
					
					
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
			
			
			if(structs.GetEnterpriseList() != null) {
				
				oprot.WriteFieldBegin("enterpriseList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.PmsActConfigModel _item0 in structs.GetEnterpriseList()){
					
					
					com.vip.pms.data.service.PmsActConfigModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMobileChannelList() != null) {
				
				oprot.WriteFieldBegin("mobileChannelList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.PmsActConfigModel _item0 in structs.GetMobileChannelList()){
					
					
					com.vip.pms.data.service.PmsActConfigModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRepeatAmountLimit() != null) {
				
				oprot.WriteFieldBegin("repeatAmountLimit");
				oprot.WriteDouble((double)structs.GetRepeatAmountLimit());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFreeCarriageList() != null) {
				
				oprot.WriteFieldBegin("freeCarriageList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.PmsActConfigModel _item0 in structs.GetFreeCarriageList()){
					
					
					com.vip.pms.data.service.PmsActConfigModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
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
			
			
			if(structs.GetBuyLimit() != null) {
				
				oprot.WriteFieldBegin("buyLimit");
				oprot.WriteI32((int)structs.GetBuyLimit()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PmsActConditionModel bean){
			
			
		}
		
	}
	
}