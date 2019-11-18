using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class PmsCommandCoreModelHelper : TBeanSerializer<PmsCommandCoreModel>
	{
		
		public static PmsCommandCoreModelHelper OBJ = new PmsCommandCoreModelHelper();
		
		public static PmsCommandCoreModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PmsCommandCoreModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetId(value);
					}
					
					
					
					
					
					if ("name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetName(value);
					}
					
					
					
					
					
					if ("code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCode(value);
					}
					
					
					
					
					
					if ("rpType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetRpType(value);
					}
					
					
					
					
					
					if ("channel".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetChannel(value);
					}
					
					
					
					
					
					if ("range".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetRange(value);
					}
					
					
					
					
					
					if ("totalLimit".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetTotalLimit(value);
					}
					
					
					
					
					
					if ("userLimit".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetUserLimit(value);
					}
					
					
					
					
					
					if ("priceLimit".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetPriceLimit(value);
					}
					
					
					
					
					
					if ("notLimitUser".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetNotLimitUser(value);
					}
					
					
					
					
					
					if ("isAllowRepeatConfig".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetIsAllowRepeatConfig(value);
					}
					
					
					
					
					
					if ("isAllowRepeat".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetIsAllowRepeat(value);
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
					
					
					
					
					
					if ("favType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetFavType(value);
					}
					
					
					
					
					
					if ("customerLevelList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.PmsActConfigModel> value;
						
						value = new List<com.vip.pms.data.service.PmsActConfigModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.PmsActConfigModel elem1;
								
								elem1 = new com.vip.pms.data.service.PmsActConfigModel();
								com.vip.pms.data.service.PmsActConfigModelHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetCustomerLevelList(value);
					}
					
					
					
					
					
					if ("saleModelList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.PmsActConfigModel> value;
						
						value = new List<com.vip.pms.data.service.PmsActConfigModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.PmsActConfigModel elem3;
								
								elem3 = new com.vip.pms.data.service.PmsActConfigModel();
								com.vip.pms.data.service.PmsActConfigModelHelper.getInstance().Read(elem3, iprot);
								
								value.Add(elem3);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetSaleModelList(value);
					}
					
					
					
					
					
					if ("isAllowBlackList".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetIsAllowBlackList(value);
					}
					
					
					
					
					
					if ("commandFavList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.PmsCommandFavModel> value;
						
						value = new List<com.vip.pms.data.service.PmsCommandFavModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.PmsCommandFavModel elem5;
								
								elem5 = new com.vip.pms.data.service.PmsCommandFavModel();
								com.vip.pms.data.service.PmsCommandFavModelHelper.getInstance().Read(elem5, iprot);
								
								value.Add(elem5);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetCommandFavList(value);
					}
					
					
					
					
					
					if ("commandScopeList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								string elem7;
								elem7 = iprot.ReadString();
								
								value.Add(elem7);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetCommandScopeList(value);
					}
					
					
					
					
					
					if ("customerSrcList".Equals(schemeField.Trim())){
						
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
						
						structs.SetCustomerSrcList(value);
					}
					
					
					
					
					
					if ("parentId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetParentId(value);
					}
					
					
					
					
					
					if ("userType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetUserType(value);
					}
					
					
					
					
					
					if ("audienceConfigList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.PmsActAudienceConfigModel> value;
						
						value = new List<com.vip.pms.data.service.PmsActAudienceConfigModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.PmsActAudienceConfigModel elem10;
								
								elem10 = new com.vip.pms.data.service.PmsActAudienceConfigModel();
								com.vip.pms.data.service.PmsActAudienceConfigModelHelper.getInstance().Read(elem10, iprot);
								
								value.Add(elem10);
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
		
		
		public void Write(PmsCommandCoreModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetId() != null) {
				
				oprot.WriteFieldBegin("id");
				oprot.WriteString(structs.GetId());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("id can not be null!");
			}
			
			
			if(structs.GetName() != null) {
				
				oprot.WriteFieldBegin("name");
				oprot.WriteString(structs.GetName());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("name can not be null!");
			}
			
			
			if(structs.GetCode() != null) {
				
				oprot.WriteFieldBegin("code");
				oprot.WriteString(structs.GetCode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("code can not be null!");
			}
			
			
			if(structs.GetRpType() != null) {
				
				oprot.WriteFieldBegin("rpType");
				oprot.WriteI32((int)structs.GetRpType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("rpType can not be null!");
			}
			
			
			if(structs.GetChannel() != null) {
				
				oprot.WriteFieldBegin("channel");
				oprot.WriteI32((int)structs.GetChannel()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("channel can not be null!");
			}
			
			
			if(structs.GetRange() != null) {
				
				oprot.WriteFieldBegin("range");
				oprot.WriteI32((int)structs.GetRange()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("range can not be null!");
			}
			
			
			if(structs.GetTotalLimit() != null) {
				
				oprot.WriteFieldBegin("totalLimit");
				oprot.WriteI32((int)structs.GetTotalLimit()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("totalLimit can not be null!");
			}
			
			
			if(structs.GetUserLimit() != null) {
				
				oprot.WriteFieldBegin("userLimit");
				oprot.WriteI32((int)structs.GetUserLimit()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("userLimit can not be null!");
			}
			
			
			if(structs.GetPriceLimit() != null) {
				
				oprot.WriteFieldBegin("priceLimit");
				oprot.WriteDouble((double)structs.GetPriceLimit());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("priceLimit can not be null!");
			}
			
			
			if(structs.GetNotLimitUser() != null) {
				
				oprot.WriteFieldBegin("notLimitUser");
				oprot.WriteBool((bool)structs.GetNotLimitUser());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("notLimitUser can not be null!");
			}
			
			
			if(structs.GetIsAllowRepeatConfig() != null) {
				
				oprot.WriteFieldBegin("isAllowRepeatConfig");
				oprot.WriteBool((bool)structs.GetIsAllowRepeatConfig());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("isAllowRepeatConfig can not be null!");
			}
			
			
			if(structs.GetIsAllowRepeat() != null) {
				
				oprot.WriteFieldBegin("isAllowRepeat");
				oprot.WriteI32((int)structs.GetIsAllowRepeat()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("isAllowRepeat can not be null!");
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
			
			
			if(structs.GetFavType() != null) {
				
				oprot.WriteFieldBegin("favType");
				oprot.WriteI32((int)structs.GetFavType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("favType can not be null!");
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
			
			
			if(structs.GetSaleModelList() != null) {
				
				oprot.WriteFieldBegin("saleModelList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.PmsActConfigModel _item0 in structs.GetSaleModelList()){
					
					
					com.vip.pms.data.service.PmsActConfigModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsAllowBlackList() != null) {
				
				oprot.WriteFieldBegin("isAllowBlackList");
				oprot.WriteBool((bool)structs.GetIsAllowBlackList());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("isAllowBlackList can not be null!");
			}
			
			
			if(structs.GetCommandFavList() != null) {
				
				oprot.WriteFieldBegin("commandFavList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.PmsCommandFavModel _item0 in structs.GetCommandFavList()){
					
					
					com.vip.pms.data.service.PmsCommandFavModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("commandFavList can not be null!");
			}
			
			
			if(structs.GetCommandScopeList() != null) {
				
				oprot.WriteFieldBegin("commandScopeList");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetCommandScopeList()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("commandScopeList can not be null!");
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
			
			
			if(structs.GetParentId() != null) {
				
				oprot.WriteFieldBegin("parentId");
				oprot.WriteString(structs.GetParentId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUserType() != null) {
				
				oprot.WriteFieldBegin("userType");
				oprot.WriteI32((int)structs.GetUserType()); 
				
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
		
		
		public void Validate(PmsCommandCoreModel bean){
			
			
		}
		
	}
	
}